using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Hotel_Winform.Model;
using System.Net.Http;
namespace Project_Hotel_Winform
{
    public class ConnectAPI
    {
        HttpClient client = new HttpClient();
        string url = "http://localhost:4444/";
        public async Task<string> getAPI(string pathname)
        {
            var response = await client.GetAsync(url + pathname);
            var responseString = await response.Content.ReadAsStringAsync();
            return responseString;
        }
        public async Task<string> postAPI(string pathname, Dictionary<string, string> param)
        {
            var content = new FormUrlEncodedContent(param);

            var response = await client.PostAsync(url + pathname, content);
            var responseString = await response.Content.ReadAsStringAsync();
            return responseString;
        }
        public async Task<string> putAPI(string pathname, Dictionary<string, string> param)
        {
            var content = new FormUrlEncodedContent(param);

            var response = await client.PutAsync(url + pathname, content);
            var responseString = await response.Content.ReadAsStringAsync();
            return responseString;
        }
        public async Task<string> deleteAPI(string pathname)
        {
            //var content = new FormUrlEncodedContent(param);

            var response = await client.DeleteAsync(url + pathname);
            var responseString = await response.Content.ReadAsStringAsync();
            return responseString;
        }
    }
}
