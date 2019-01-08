
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTO.General.NetWork
{
    public class NetWorkService
    {
        HttpPostHelper _httpPostHelper = new HttpPostHelper();


        Tuple<string, string, string, string> ConvertJContainer(JContainer jsonResult, string err)
        {
            if (jsonResult != null)
            {
                Func<object, string> func = l => l == null ? null : l.ToString();

                Tuple<string, string, string, string> result = new Tuple<string, string, string, string>(func(jsonResult["code"]),
                    func(jsonResult["msg"]), func(jsonResult["data"]), err);

                return result;
            }
            else
            {
                return null;
            }
        }

        string ConvertToDataJContainer(JContainer jsonResult, string err)
        {
            if (jsonResult != null)
            {
                return jsonResult.ToString();
            }
            else
            {
                return null;
            }
        }

        public string Post(string url, Dictionary<string, string> dic,bool isjson, out string err)
        {

            JContainer jContainer;

            //string url = _base.GetServiceUrl(type);

            _httpPostHelper.PostData(url, dic, out jContainer, out err, isjson);

            if (jContainer == null)
            {
                return null;
            }

            return this.ConvertToDataJContainer(jContainer, err);
        }


        public JContainer PostData(string url,string json)
        {
           return  _httpPostHelper.Post(url,json);
        }




        ///// <summary> 可签退列表数据接口 </summary>
        //public List<LeaveEntity> PostQueryObservHz(string jgdm, out string err)
        //{
        //    Dictionary<string, string> dic = new Dictionary<string, string>();

        //    dic.Add("jgdm", jgdm);

        //    string str = this.Post(URLEnum.queryObservHz, dic, out err);

        //    var result = str.JsonDeserialize<List<LeaveEntity>>();

        //    return result;

        //}


    }
}
