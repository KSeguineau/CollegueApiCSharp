using System.Collections.Generic;
using ColleguesApi.Controllers.DTO;
using ColleguesApi.Models;

namespace ColleguesApi.Services
{
    public interface ICollegueService
    {
        IEnumerable<string> RechercheParNom(string nom);
        Collegue RechercheParMatricule(string matricule);
        Collegue CreationCollegue(CreationColleguePostDTO creationColleguePostDTO);

    }
}