﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using APP_LAB_ENG_SW.Models;
using Newtonsoft.Json;

namespace APP_LAB_ENG_SW.Services
{
    class ViaCEP
    {
        private static string EnderecoURL = "https://viacep.com.br/ws/{0}/json/";

        public static Pessoa BuscarEnderecoViaCEP(string cep)
        {
            string NovoEnderecoURL = string.Format(EnderecoURL, cep);

            WebClient wc = new WebClient();
            string Conteudo = wc.DownloadString(NovoEnderecoURL);

            Pessoa end = JsonConvert.DeserializeObject<Pessoa>(Conteudo);

            if (end.cep == null) return null;

            return end;
        }
    }
}
