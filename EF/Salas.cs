using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleSalasPortal.EF
{
    public class Salas
    {
        public int Id { get; set; }

        public Boolean Status { get; set; }

        public int NumeroSala { get; set; }

        public string NomeSala { get; set; }

        public string ProfessorResponsavel { get; set; }
    }
}
