using Newtonsoft.Json;
using Reflection.Interfaces;

namespace Reflection.Providers
{
	public class FileConfigurationProvider : IConfigurationProvider
    {
        private readonly string filePath;

        public FileConfigurationProvider()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            filePath = Path.Combine(documentsPath, "config.txt");

            Console.WriteLine($"FileConfigurationProvider: {filePath}");
        }

        public object GetValue(string settingName)
        {
			if (string.IsNullOrEmpty(filePath))
				throw new ArgumentNullException("filePath", "File path cannot be null or empty.");

			using (StreamReader reader = File.OpenText(filePath))
            {
                var content = reader.ReadToEnd();
                var settings = JsonConvert.DeserializeObject<Dictionary<string, object>>(content);
                if (settings.TryGetValue(settingName, out var value))
                {
                    return value;
                }

                return null;
            }
        }

        public void SetValue(string settingName, object value)
        {
            string content;

            if (string.IsNullOrEmpty(filePath)) 
				throw new ArgumentNullException("filePath", "File path cannot be null or empty.");

            using (StreamReader reader = File.OpenText(filePath))
            {
                content = reader.ReadToEnd();
                Console.WriteLine(content.ToString());

			}

			var settings = JsonConvert.DeserializeObject<Dictionary<string, object>>(content);
            settings[settingName] = value;
            using (StreamWriter writer = File.CreateText(filePath))
            { 
                writer.Write(JsonConvert.SerializeObject(settings));
            }
        }
    }
}
