using SysGestao.SystemScreens.PrimaryScreens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestao.SystemScreens.ClientScreens
{
    public class UpdateClientScreen
    {
        public static void Load()
        {
            Console.Clear();
            Layout.Load();
            //Title();
            //WhiteOption();
            Console.CursorVisible = true;
        }
    }
}
