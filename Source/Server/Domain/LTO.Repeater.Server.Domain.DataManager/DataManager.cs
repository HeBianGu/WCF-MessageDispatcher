using HEW.General.Data.Local;
using LTO.Repeater.Base.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTO.Repeater.Server.Domain.DataManager
{
    public class DataManager
    {

        public static DataManager Instance = new DataManager();

        /// <summary> 运行日志 </summary>
        public void Info(params string[] message)
        {
            Log4Servcie.Instance.Info(message);
        }

        /// <summary> 错误日志 </summary>
        public void Error(params Exception[] ex)
        {
            Log4Servcie.Instance.Error(ex);
        }

        public void Error(string message, Exception ex)
        {
            Log4Servcie.Instance.Error(message, ex);
        }

        public string JsonResult()
        {
            var result = ResultMessage.Create();

            return JsonConvert.SerializeObject(result);
        }
    }

  
}
