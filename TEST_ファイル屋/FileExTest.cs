using 尾画茶;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TEST_ファイル屋
{
    
    
    /// <summary>
    ///FileExTest のテスト クラスです。すべての
    ///FileExTest 単体テストをここに含めます
    ///</summary>
    [TestClass()]
    public class FileExTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///現在のテストの実行についての情報および機能を
        ///提供するテスト コンテキストを取得または設定します。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 追加のテスト属性
        // 
        //テストを作成するときに、次の追加属性を使用することができます:
        //
        //クラスの最初のテストを実行する前にコードを実行するには、ClassInitialize を使用
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //クラスのすべてのテストを実行した後にコードを実行するには、ClassCleanup を使用
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //各テストを実行する前にコードを実行するには、TestInitialize を使用
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //各テストを実行した後にコードを実行するには、TestCleanup を使用
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///全ファイル取得 のテスト
        ///</summary>
        [TestMethod()]
        public void 全ファイル取得Test()
        {
            if(Directory.Exists(@"C:\PathTest")) Directory.Delete(@"C:\PathTest",true);
            Directory.CreateDirectory(@"C:\PathTest");
            Directory.CreateDirectory(@"C:\PathTest\Dir1");
            Directory.CreateDirectory(@"C:\PathTest\Dir1\Dir2");
            File.WriteAllText(@"C:\PathTest\一番上.txt","test");
            File.WriteAllText(@"C:\PathTest\Dir1\二番.txt", "test");
            File.WriteAllText(@"C:\PathTest\Dir1\Dir2\三番.txt", "test");
            var filesAndDirectories = new[] { @"C:\PathTest\Dir1", @"C:\PathTest\一番上.txt" };
            var expected = new[] { @"C:\PathTest\一番上.txt", @"C:\PathTest\Dir1\二番.txt", @"C:\PathTest\Dir1\Dir2\三番.txt" };
            var actual = FileEx.全ファイル取得(filesAndDirectories).OrderBy(p=>p.Length).ToArray();
            Assert.AreEqual(string.Join(",",expected), string.Join(",",actual));
        }
    }
}
