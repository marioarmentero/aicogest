using aicoffi.modelos;
using aicogestnew.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace aicoffi.Servicios
{
   public class LoginService:Ilogin<Login>
    {
        readonly List<Login> Login;

        public async Task<List<Login>> GetLoginAsync()
        {
            var credentials = new NetworkCredential("vabowl", "P3lvmt3n");
            var handler = new HttpClientHandler { Credentials = credentials };
            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient(handler);
            List<Login> Model = null;

            var response = await client.GetAsync("http://167.86.119.48:83/api/usuarios");

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonstring = await response.Content.ReadAsStringAsync();

                Model = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Login>>(jsonstring);

                return Model;

            }
            else
            {
                return null;
            }
        }
        
    }
}
