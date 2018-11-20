using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agency;

namespace NekoConsole
{
    class NekoAgent
    {
        private static dynamic _neko;

        public static void Init()
        {
            _neko = Agency.Agency.SpawnAgent("Project-AZUSA-NekoWallpaper", new TcpHandler(port: 34396));
        }

        /// <summary>
        /// Change character by name & costume
        /// </summary>
        /// <param name="name"></param>
        /// <param name="costume"></param>
        public static void ChangeCharacter(string name, string costume)
        {
            _neko.ChangeCharacter(name, costume);
        }

        public static float Volume
        {
            get
            {
                if (_neko == null)
                {
                    return 0;
                }
                return _neko.Volume;
            }
            set
            {
                if (_neko != null)
                {
                    _neko.Volume = value;
                }
            }
        }

        public static async void Test()
        {
            Init();
            for (float i = 0; i < 1; i+=0.01f)
            {
                _neko.Volume = i;
                await Task.Delay(100);
            }
            //var vol = _neko.Volume;
            //ChangeCharacter("maple","");
        }
    }
}
