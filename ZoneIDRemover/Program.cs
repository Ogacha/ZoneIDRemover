using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using 尾画茶;
using System.Text;

namespace ZoneIDRemover
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main(string[] fileAndDirectories)
        {
            if (fileAndDirectories.Length == 0)
            {
                MessageBox.Show("ファイルのブロックを解除するには、\r\n"
                +"解除したいファイルやフォルダーをブロック解除くんに\r\n"
                +"ドラッグ＆ドロップなどして、起動してください。\r\n"
                +"複数ファイルやフォルダー一括にも対応しています。",
                "ブロック解除くんの使い方",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            var files = FileEx.全ファイル取得(fileAndDirectories);
            var 結果 = files.Select(file => new { ファイル名 = file, 結果 = ADS係.RemoveZoneID(file) }).ToArray();
            if (結果.All(result => result.結果 == null))
            {
                MessageBox.Show("ブロックされているファイルはありませんでした。");
                return;
            }
            var mes=new StringBuilder();
            var 失敗= string.Join("\r\n", 結果.Where(result => result.結果 == false)
                    .Select(result => result.ファイル名));
            var 成功数=結果.Count(result=>result.結果==true);
            if(成功数>0) mes.AppendFormat("ブロック解除にすべて成功しました。（{0}個）",成功数).AppendLine();
            if(成功数>0 && 失敗.Any()) mes.Append("ただし、");
            if (失敗.Any())
            {
                mes.AppendLine("以下のファイルのブロック解除に失敗しました。").AppendLine(失敗);
                MessageBox.Show( mes.ToString() , "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show(mes.ToString());
            }
        }
    }
}
