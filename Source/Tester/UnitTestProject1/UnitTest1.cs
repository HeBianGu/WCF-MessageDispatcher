using System;
using System.Collections.Generic;
using System.Diagnostics;
using LTO.General.NetWork;
using LTO.Repeater.Base.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            NetWorkService netWorkService = new NetWorkService();

            Dictionary<string, string> dic = new Dictionary<string, string>();

            //dic.Add("message", "34343");
            //dic.Add("type", "6767");
            //dic.Add("level", "你78好");

            string err;

            var str = netWorkService.Post("http://localhost:22889/PostMessage?message=你好&type=可以&level=还行", dic, false, out err);


            Debug.WriteLine(str);

        }

        [TestMethod]
        public void TestMethod2()
        {
            NetWorkService netWorkService = new NetWorkService();

            MessageEntity messageEntity = new MessageEntity();
            messageEntity.message = "这是我的消息";
            messageEntity.level = "消息的优先级";
            messageEntity.type = "消息的类型";

            string json = JsonConvert.SerializeObject(messageEntity);

            var str = netWorkService.PostData("http://localhost:22889/PostEntity", json);

            Debug.WriteLine(str);

        }
    }
}
