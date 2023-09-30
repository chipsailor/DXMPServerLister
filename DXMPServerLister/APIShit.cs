using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace DXMPServerLister
{
    internal class APIShit
    {
        string TTTNWURL = "https://master.333networks.com/json/deusex"; /* 2023 comments for future monica-- if u dont know what this is ur hyperstupid */

        HttpClient dxmpslClient = new HttpClient(); /* initialises a new httpclient using the dxmpslClient name, using HttpClientHandler */
        HttpResponseMessage dxmpslResponseMessage; /* ditto as above, but with HttpResponseMessage :) */

        public async Task<string> getTTTNWServersByName(string servname)
        {
            dxmpslResponseMessage = await dxmpslClient.GetAsync(TTTNWURL+"?hostname"+servname);
            string JSONSHIT = await dxmpslResponseMessage.Content.ReadAsStringAsync();
            return JSONSHIT;
        }


    }
}
