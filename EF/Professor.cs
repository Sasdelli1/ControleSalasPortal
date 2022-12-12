using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleSalasPortal.EF
{
    public class Professor
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public Boolean Status { get; set; }

        public string Sala { get; set; }

        public DateTime Agenda { get; set; }
    }
}
