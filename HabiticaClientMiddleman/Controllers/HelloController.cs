using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using HabiticaClientMiddleman.Models;
using RestSharp;
using Newtonsoft.Json;

namespace HabiticaClientMiddleman.Controllers
{
    public class HelloController : Controller
    {
        public string Index(string habiticaUser, string habiticaKey)
        {
            var client = new RestClient();
            client.BaseUrl = new Uri("https://habitica.com");
            var request = new RestRequest();
            request.Resource = "/api/v2/user/tasks";
            request.AddHeader("x-api-user", habiticaUser);
            request.AddHeader("x-api-key", habiticaKey);
            IRestResponse response = client.Execute(request);

            var dailyList = JsonConvert.DeserializeObject<List<Daily>>(response.Content);
            var listToSend = dailyList.Where(q => q.type == "daily").Where(p => p.completed == false).Select(x => new DailyDTO
            {
                Id = x.id,
                Name = x.text
            }).ToList();
            var listJson = JsonConvert.SerializeObject(listToSend);
            return listJson;
        }

        public string CheckTask(string habiticaUser, string habiticaKey, string taskId)
        {
            var client = new RestClient();
            client.BaseUrl = new Uri("https://habitica.com");
            var request = new RestRequest(Method.POST);
            request.Resource = ("/api/v2/user/tasks/" + taskId + "/up");
            request.AddHeader("x-api-user", habiticaUser);
            request.AddHeader("x-api-key", habiticaKey);
            IRestResponse response = client.Execute(request);
            var responseObj = JsonConvert.DeserializeObject<TaskResponse>(response.Content);
            return ("%" + responseObj.gp.ToString("0.00") + "g"); //The extra characters help while reading the response on the arduino
        }
    }
}
