using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEZOND
{
    class Klanten
    {
        public int KlantId { get; set; }
        public string KlantNaam { get; set; }
        public string KlantAdres { get; set; }
        public string KlantPostcode { get; set; }
        public string KlantPlaats { get; set; }
        public int ArtsId { get; set; }
        public int MedicatieId { get; set; }
        public int VerzekeraarId { get; set; }
    }
}
