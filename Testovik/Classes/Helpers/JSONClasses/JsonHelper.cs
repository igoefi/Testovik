using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testovik.Classes.Helpers.JSON;

namespace Testovik.Classes.Helpers
{
    internal class JsonHelper
    {
        private static string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "testiki.json";


        public static void SaveTest(Test test)
        {
            var file = new AllTests();
            if (File.Exists(filePath))
                file = GetAllTests();

            file.AddTest(test);
            JSONSerializeController.SerializeObject(test, filePath);
        }

        public static Test LoadTest(string tag) 
        {
            if (File.Exists(filePath))
                return null;

            var tests = GetAllTests();
            foreach(var test in tests.Tests)
                if(test.Tag == tag)
                    return test;
            return null;
        }

        private static AllTests GetAllTests() =>
            JSONSerializeController.DeserializeObject<AllTests>(filePath);

        public class JSONSerializeController
        {
            static public void SerializeObject(object obj, string path)
            {
                if (obj == null) return;

                JsonSerializer serializer = new JsonSerializer();
                serializer.Converters.Add(new JavaScriptDateTimeConverter());
                serializer.NullValueHandling = NullValueHandling.Ignore;

                using (StreamWriter sw = new StreamWriter(path))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, obj);
                }
            }

            static public T DeserializeObject<T>(string path)
            {
                if (string.IsNullOrWhiteSpace(path)) return default;

                T obj;
                JsonSerializer serializer = new JsonSerializer();
                using (StreamReader rd = new StreamReader(path))
                using (JsonReader reader = new JsonTextReader(rd))
                {
                    obj = serializer.Deserialize<T>(reader);
                }
                return obj;
            }

        }
    }
}
