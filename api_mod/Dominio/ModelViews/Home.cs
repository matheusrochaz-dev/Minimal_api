using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dominio.ModelViews
{
    public struct Home
    {
        public string Mensagem {get => "Bem vindo a Api";} 
        public string Doc {get => "/swagger";} 
    }
}