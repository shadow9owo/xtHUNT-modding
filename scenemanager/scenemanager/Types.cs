using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scenemanager
{
    namespace Locations
    {
        public enum Scenes
        {
            Scene_MainMenu,
            Scene_Game
        }
        public enum Map
        {
            Map_None,
            Map_Home,
            Map_Hallway,
            Map_outsidehome
        };
    }
    namespace IDS
    {
        public enum TextureIds
        {
            None,
            CursorHover,
            CursorGrab,
            texture_Home,
            texture_hallway,
            Texture_outside_home,
            Eye,
            Eye2
        }
        public enum ItemID
        {
            None = 0
        }
    }
    class Types
    {
        public struct Vector2I
        {
            public int x;
            public int y;
            public Vector2I(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public override string ToString()
            {
                return $"({x}, {y})";
            }
        }

        public struct Rect
        {
            public int x;
            public int y;
            public int w;
            public int h;
            public Rect(int x, int y, int w, int h)
            {
                this.x = x;
                this.y = y;
                this.w = w;
                this.h = h;
            }
            public override string ToString()
            {
                return $"({x}, {y}, {w}, {h})";
            }
        }

        public enum OnClickAction
        {
            None,
            ChangeScene,
            ChangeTexture,
            DisplayMessage,
            PickupItem
        }
        public struct GameObjectData
        {
            public IDS.TextureIds textureid;
            public IDS.ItemID objectid;
            public bool clickable;
            public Rect screencords; //max by default 720p
            public OnClickAction onClickAction;
            public object arguments;
        }
        public struct SceneData
        {
            public List<GameObjectData> gameobjectlist;
            public string scenename;
            public int sceneid;
        }
    }
}