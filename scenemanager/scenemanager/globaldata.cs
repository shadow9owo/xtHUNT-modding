using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace scenemanager
{
    internal class globaldata
    {
        public static string filename = "main.json";
        public static List<Types.GameObjectData> gameobjectbuffer = new List<Types.GameObjectData>();
        public static List<Types.SceneData> scenebuffer = new List<Types.SceneData>();

        public static void Init()
        {
            gameobjectbuffer = new List<Types.GameObjectData>();
            scenebuffer = new List<Types.SceneData>();
            return;
        }

        public static void Append(Types.GameObjectData data)
        {
            gameobjectbuffer.Insert(0,data);
            return;
        }

        public static void save()
        {
            List<Types.SceneData> context = new List<Types.SceneData>();
            //append to context
            if (File.Exists(filename))
            {
                context = JsonConvert.DeserializeObject<List<Types.SceneData>>(File.ReadAllText(filename));

                Form1 f1 = new Form1();

                RichTextBox bgimg = f1.Controls.Find("backgroundimg", true).FirstOrDefault() as RichTextBox;
                RichTextBox sceneid = f1.Controls.Find("sceneid", true).FirstOrDefault() as RichTextBox;
                RichTextBox scenename = f1.Controls.Find("scenename", true).FirstOrDefault() as RichTextBox;

                int.TryParse(sceneid.Text, out int a);

                Types.SceneData data = new Types.SceneData
                {
                    bgpath = bgimg.Text,
                    gameobjectlist = gameobjectbuffer,
                    sceneid = a,
                    scenename = scenename.Text
                };

                context.Add(data);
                File.Delete(filename);
            }



            string json = JsonConvert.SerializeObject(context, Formatting.Indented);
            File.WriteAllText(filename,json);
            gameobjectbuffer.Clear();
            scenebuffer.Clear();
            return;
        }
        public static void load()
        {
            scenebuffer = JsonConvert.DeserializeObject<List<Types.SceneData>>(File.ReadAllText(filename));
            return;
        }

        public static void open()
        {
            Process.Start(filename);
            return;
        }
    }
}
