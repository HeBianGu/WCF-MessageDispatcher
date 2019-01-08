using HEW.General.Data.Local;
using LTO.Repeater.Domain.DataManager;
using LTO.Repeater.Domain.ServerManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LTO.WindowsService.Repeater
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();

           
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                //Thread.Sleep(30000);

                string documentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                // Todo ：初始化 
                DataManager.Instance.InitLogger();

                DataManager.Instance.Info("开始启动服务！");

                ServiceRegisterService.Instance.RegisterConfigDemo();

                DataManager.Instance.Info(documentPath);

                DataManager.Instance.Info("服务启动成功！");

            }
            catch (Exception ex)
            {
                DataManager.Instance.Info("服务启动错误！"); 
                DataManager.Instance.Error(ex);
            }
        }

        protected override void OnStop()
        {

            DataManager.Instance.Info("服务停止！");
        }
    }
}
