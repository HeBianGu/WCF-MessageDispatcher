using LTO.Repeater.Base.Interface;
using LTO.Repeater.Server.Domain.DataManager;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LTO.Repeater.Server.WCF.DataMessage
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“DataMessage”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 DataMessage.svc 或 DataMessage.svc.cs，然后开始调试。
    public class DataMessage : IDataMessage
    {
        public ResultMessage PostEntity(MessageEntity message)
        {
            DataManager.Instance.Info("message:" + message.message);
            DataManager.Instance.Info("type:" + message.type);
            DataManager.Instance.Info("level:" + message.level);

            return ResultMessage.Create();
        }

        public ResultMessage PostMessage(string message, string type, string level)
        {
            DataManager.Instance.Info("message:" + message);
            DataManager.Instance.Info("type:" + type);
            DataManager.Instance.Info("level:" + level);

            //return DataManager.Instance.JsonResult();

            return ResultMessage.Create();

        }

        public string PostMMM(string message)
        {
            DataManager.Instance.Info("message:" + message);

            return "TRUE";
        }

        public string TestGet()
        {
            Console.WriteLine("TestGet成功");

            DataManager.Instance.Info("TestGet成功");

            return "TestGet成功";
        }

        public string TestPost(string message)
        {
            Console.WriteLine(message);

            DataManager.Instance.Info(message);

            return "成功";
        }
    }
}
