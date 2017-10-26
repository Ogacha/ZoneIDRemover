using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace 尾画茶
{
    public static class FileEx
    {
        public static IEnumerable<string> 全ファイル取得(IEnumerable<string> filesAndDirectories)
        {
            foreach (var fd in filesAndDirectories)
            {
                var info = GetFileSystemInfo(fd);
                if (info is FileInfo || info == null) yield return fd;
                else
                {
                    var files = Directory.GetFiles(fd, "*", SearchOption.AllDirectories);
                    foreach (var file in files) yield return file;
                }
            }
        }

        /// <summary>
        /// ファイルかフォルダーか判別の付かないパスの FileSystemInfo を返す。
        /// 存在しないパスの場合は、null が返る。
        /// </summary>
        /// <param name="path">ファイルかフォルダーのパス</param>
        /// <returns>FileSystemInfo。パスが存在しない場合は、null。</returns>
        public static FileSystemInfo GetFileSystemInfo(string path)
        {
            if (Directory.Exists(path)) return new DirectoryInfo(path);
            if (File.Exists(path)) return new FileInfo(path);
            return null;
        }
    }
}
