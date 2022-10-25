using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Newtonsoft.Json;

namespace CyoloFrontApp.App_Start
{
    
    public class LawyerService
    {
        private RestClient _client;
        public LawyerService()
        {
            _client = new RestClient("https://cyoloapigateway.azure-api.net");
        }

        public void Dispose()
        {

        }

        public async Task<dynamic> GetCourtCaseByEmailAndDate(string email, string date)
        {
            var request = new RestRequest($"/api/Custom/CourtCaseByDateAndEmail/{date}/{email}");
            request.AddHeader("ocp-apim-subscription-key", "d23d9c7c11da4b228417e567c85fa80c");
            var response = await _client.GetAsync(request);
            return JsonConvert.DeserializeObject<dynamic>(response.Content);
        }

        public async Task<dynamic> GetLawyersByCourtcaseno(string courtcaseno)
        {
            var request = new RestRequest($"/api/Custom/LawyersByCourtCaseId/{courtcaseno}");
            request.AddHeader("ocp-apim-subscription-key", "d23d9c7c11da4b228417e567c85fa80c");
            var response = await _client.GetAsync(request);
            return JsonConvert.DeserializeObject<dynamic>(response.Content);
        }

    }
}