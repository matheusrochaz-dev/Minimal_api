using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dominio.Enus;

namespace API.Dominio.ModelViews
{
    public record AdministradorModelViews
    {
        public int Id {get; set;} = default!;
        public string Email {get; set;} = default!;
        public string Perfil {get; set;} = default!;
    }
}