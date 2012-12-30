using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using 尾画茶;

namespace ZoneIDRemover
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main(string[] files)
        {
            if (files.Length == 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new 設定画面());
            }
            else
            {
                foreach (var file in files) ADS係.RemoveZoneID(file);
            }
        }
    }
}
