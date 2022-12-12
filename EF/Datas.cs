using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleSalasPortal.EF
{
    public class Datas
    {
        public int Id { get; set; }

        public string Dia { get; set; }

        public int QuantidadeSalaOcupado { get; set; }

        public int QuantidadeSalaLivre { get; set; }
    }
}
