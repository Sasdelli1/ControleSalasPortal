using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleSalasPortal.EF
{
    public class Turmas
    {
        public int Id { get; set; }

        public string Curso { get; set; }

        public int QuantidadeAluno { get; set; }

        public string Professor { get; set; }

        public string Sala { get; set; }
    }
}
