using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleSalasPortal.EF
{
    public class Alunos
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Turma { get; set; }

        public string Periodo { get; set; }

        public string Sala { get; set; }
    }
}
