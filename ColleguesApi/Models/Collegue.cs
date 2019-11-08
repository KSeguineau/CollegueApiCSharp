using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColleguesApi.Models
{
    public class Collegue
    {

        public Guid Matricule { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public DateTime Ddn { get; set; }
        public Uri PhotoUrl { get; set; }

        public Collegue()
        {

        }

        public Collegue(Guid matricule, string nom, string prenom, string email, DateTime ddn, Uri photoUrl)
        {
            Matricule = matricule;
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Ddn = ddn;
            PhotoUrl = photoUrl;
        }
    }
}
