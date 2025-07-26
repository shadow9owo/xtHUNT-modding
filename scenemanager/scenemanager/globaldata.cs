using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace scenemanager
{
    internal class globaldata
    {
        public static string filename = "main.json";
        public static List<Types.GameObjectData> gameobjectbuffer = new List<Types.GameObjectData>();

        public static void Init()
        {
            gameobjectbuffer = new List<Types.GameObjectData>();
            return;
        }

        public static void Append(Types.GameObjectData data)
        {
            gameobjectbuffer.Insert(0,data);
            return;
        }

        public static void save()
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            string json = JsonConvert.SerializeObject(gameobjectbuffer, Formatting.Indented);
            File.WriteAllText(filename,json);
            return;
        }
        public static void load()
        {
            gameobjectbuffer = JsonConvert.DeserializeObject<List<Types.GameObjectData>>(File.ReadAllText(filename));
            return;
        }
    }
}
