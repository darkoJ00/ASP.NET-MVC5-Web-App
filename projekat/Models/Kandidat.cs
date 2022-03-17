using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projekat.Models
{
    public class Kandidat:KandidatZaposlen
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Struka { get; set; }
        public string Interes{ get; set; }
        public string Iskustvo { get; set; }
        public string Poruka { get; set; }

    }
}