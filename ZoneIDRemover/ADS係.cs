using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Trinet.Core.IO.Ntfs;

namespace 尾画茶
{
    /// <summary>
    /// Alternate Data Stream を扱うクラス。
    /// using 尾画茶; で System.IO.FileInfo の拡張メソッドが使えます。
    /// 通常の静的メソッドで文字列でも指定できます。
    /// </summary>
    public static class ADS係
    {
        /// <summary>
        /// FileInfo を指定して、ZoneID を持っているかどうかを返します。
        /// </summary>
        public static bool HasZoneID(this FileInfo body)
        {
            return body.AlternateDataStreamExists("Zone.Identifier");
        }

        /// <summary>
        /// ファイルパスを指定し、ZoneID を持っているかどうかを返します。
        /// </summary>
        public static bool HasZoneID(string filePath)
        {
            return new FileInfo(filePath).HasZoneID();
        }

        /// <summary>
        /// FileInfo を指定して、ZoneID の削除を試みます。
        /// </summary>
        /// <returns>削除に成功は True、失敗は False、ZoneID がない場合は Null</returns>
        public static bool? RemoveZoneID(this FileInfo body)
        {
            try
            {
                if (!body.HasZoneID()) return null;
                body.DeleteAlternateDataStream("Zone.Identifier");
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// ファイルパスを指定し、ZoneID の削除を試みます。
        /// </summary>
        public static bool? RemoveZoneID(string filePath)
        {
            return new FileInfo(filePath).RemoveZoneID();
        }
    }
}
