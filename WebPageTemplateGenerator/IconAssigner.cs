using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace WebPageTemplateGenerator
{
    public class IconAssigner
    {
        private const string FILE_EXT = ".rbbtemplate";
        private static readonly string ICO_DIR = Environment.ExpandEnvironmentVariables("%AppData%") + "\\rbucinell\\";
        private static readonly string ICO_PATH = ICO_DIR + "rbbtemplate_icon.ico";

        /// <summary>
        /// 
        /// </summary>
        public static void Execute()
        {
            if ( !IsAssociated() )
            {
                UnpackIcon();
                //Associate();
            }
        }

        private static bool IsAssociated()
        {
            return ( Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\" + FILE_EXT, false) == null );
        }

        /// <summary>
        /// Unpacks Icon from resources and saves it to appdata
        /// </summary>
        private static void UnpackIcon()
        {
            if ( !File.Exists(ICO_PATH) )
            {
                Icon extIcon = Properties.Resources.rbbtemplate_icon;
                if ( !Directory.Exists(ICO_DIR) )
                {
                    Directory.CreateDirectory(ICO_DIR);
                }
                using ( FileStream fs = new FileStream(ICO_PATH, FileMode.Create, FileAccess.Write) )
                {
                    extIcon.Save(fs);
                }
            }
        }

        private static void Associate()
        {
            RegistryKey classesRoot = Registry.ClassesRoot.CreateSubKey(FILE_EXT);
            classesRoot.CreateSubKey("DefaultIcon").SetValue("", ICO_PATH);
            SHChangeNotify(0x08000000, 0x0000, IntPtr.Zero, IntPtr.Zero);
        }

        private static void Associate2()
        {
            RegistryKey FileReg  = Registry.CurrentUser.CreateSubKey("Software\\Class\\" + FILE_EXT);
            RegistryKey AppReg   = Registry.CurrentUser.CreateSubKey("Software\\Classes\\Applications\\WebPageTemplateGenerator.exe");
            RegistryKey AppAssoc = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\" + FILE_EXT);


            FileReg.CreateSubKey("DefaultIcon").SetValue("", ICO_PATH);
            FileReg.CreateSubKey("PerceivedType").SetValue("", "Text");

            AppReg.CreateSubKey("shell\\open\\command").SetValue("", ""+ Application.ExecutablePath + "\"%1");
            AppReg.CreateSubKey("DefaultIcon").SetValue("", ICO_PATH);

            AppAssoc.CreateSubKey("UserChoice").SetValue("Progid", "Applications\\WebPageTemplateGenerator.exe");

            SHChangeNotify(0x08000000, 0x0000, IntPtr.Zero, IntPtr.Zero);
        }

        [DllImport("Shell32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern void SHChangeNotify( uint wEventId, uint uFlags, IntPtr dwItem1, IntPtr dwItem2 );
    }
}
