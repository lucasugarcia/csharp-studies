﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {
        private readonly string _argumentos;
        public string Url { get; }
    
        public ExtratorValorDeArgumentosURL(string url)
        {
            if (string.IsNullOrEmpty(url))
                throw new ArgumentException("O argumento url não pode ser nulo ou vazio.", nameof(url));

            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);
            
            Url = url;
        }

        public string GetValor(string nomeParametro)
        {
            int indiceParametro = _argumentos.IndexOf(nomeParametro) + nomeParametro.Length + 1;
        }
    }
}
