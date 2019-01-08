using LTO.Repeater.Domain.DataManager;
using LTO.Repeater.Domain.ServerManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LTO.Appliaction.Host.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Todo ：初始化 
                DataManager.Instance.InitLogger();

                ServiceRegisterService.Instance.RegisterConfigDemo();

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }

            System.Console.Read();

            System.Console.ReadKey();

        }
    }
}
