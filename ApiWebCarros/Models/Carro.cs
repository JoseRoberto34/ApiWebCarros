using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWebCarros.Models
{
    public class Carro
    {
        public Guid Id { get; set; }
        public string Modelo { get; set; }
        public string Ano { get; set; }
        public string Marca { get; set; }
        public string Linking { get; set; }

        public Carro()
        {
            Id = Guid.NewGuid();
        }
    }
}
