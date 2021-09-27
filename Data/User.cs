using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Projetos.Data
{
    public class User
    {
        public int idUser {get; set;}
        public string nome {get; set;}
        public string senha {get; set;}
    }

    
}