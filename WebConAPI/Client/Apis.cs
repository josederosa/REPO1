using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace WebConAPI.Client
{
    public class Apis
    {

        static AgentesWA s_agentes = null;

        public static async Task <AgentesWA> GetAgentes()
        {
            if (s_agentes == null)
            { 
                string? _token = await TokenAdmin.Get();

                if (_token is not null)
                {
                    TokenAdmin.Client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _token);
                    s_agentes = await TokenAdmin.Client.GetFromJsonAsync<AgentesWA>("https://intranet.bas.com.ar/bascsapiv02/api/agente?pageSize=100&Version=2");
                }
            }
            return s_agentes;
        }

        public class AgentesWA
        {
            public List<WebConAPI.Shared.Agente> Agentes { get; set; }
        }
               

    }
}
