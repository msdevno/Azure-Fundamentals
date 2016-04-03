using ContactList.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ContactList
{
    public class GenericStorage
    {
        private string _filePath;

        public GenericStorage()
        {
            var webAppsHome = Environment.GetEnvironmentVariable("HOME")?.ToString();
            if (String.IsNullOrEmpty(webAppsHome))
            {
                _filePath = Path.GetDirectoryName(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath) + "\\";
            }
            else
            {
                _filePath = webAppsHome + "\\site\\wwwroot\\";
            }
        }

        public async Task Save<T>(IEnumerable<T> target, string filename) where T : class
        {
            var json = JsonConvert.SerializeObject(target);
            File.WriteAllText(_filePath + filename, json);
        }

        public async Task<IEnumerable<T>> Get<T>(string filename) where T : class
        {
            var resultText = String.Empty;
            if (File.Exists(_filePath + filename))
            {
                resultText = File.ReadAllText(_filePath + filename);
            }

            var result = JsonConvert.DeserializeObject<T[]>(resultText);
            return result;
        }
    }
}
