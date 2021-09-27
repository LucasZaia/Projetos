using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projetos.Data;
using Projetos.database;

namespace Projetos.Models
{
    public class PopulaBd
    {
        public void inserir(DbProvider context)
        {
            context.Database.EnsureCreated();
            if (context.Users.Any()) {
                return;
            }

            var user = new User[]
            {
                new User{nome="Lucas"},
                new User{nome="Gabriel"},
                new User {nome="Thiago"}
            };

            foreach(User u in user)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();
        }
    }
}
