using AutoMapper;
using ColleguesApi.Controllers.DTO;
using ColleguesApi.Exceptions;
using ColleguesApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColleguesApi.Services
{
    public class CollegueService : ICollegueService
    {
        private Dictionary<string, Collegue> _data = new Dictionary<string, Collegue>();
        private readonly IMapper _mapper;

        public CollegueService(IMapper mapper)
        {
            _mapper = mapper;
            var collegue1 = new Collegue(Guid.NewGuid(), "bobby", "bob", "bob@bobby.fr", DateTime.Now, new Uri("http://photo.fr"));
            var collegue2 = new Collegue(Guid.NewGuid(), "tommy", "tom", "bob@bobby.fr", DateTime.Now, new Uri("http://photo.fr"));
            var collegue3 = new Collegue(Guid.NewGuid(), "poppy", "pop", "bob@bobby.fr", DateTime.Now, new Uri("http://photo.fr"));
            var collegue4 = new Collegue(Guid.NewGuid(), "rorry", "ror", "bob@bobby.fr", DateTime.Now, new Uri("http://photo.fr"));

            _data.Add(collegue1.Matricule.ToString(), collegue1);
            _data.Add(collegue2.Matricule.ToString(), collegue2);
            _data.Add(collegue3.Matricule.ToString(), collegue3);
            _data.Add(collegue4.Matricule.ToString(), collegue4);

        }

        public IEnumerable<string> RechercheParNom(string nom)
        {
            return from keyValue in _data where keyValue.Value.Nom.Equals(nom, System.StringComparison.OrdinalIgnoreCase) select keyValue.Value.Matricule.ToString();
        }

        public Collegue RechercheParMatricule(string matricule)
        {
            try
            {
                return _data[matricule];
            }
            catch (Exception)
            {

                throw new CollegueNonTrouveException("Collegue non trouvé");
            }
        }

        public Collegue CreationCollegue(CreationColleguePostDTO creationColleguePostDTO)
        {
            var collegue = _mapper.Map<CreationColleguePostDTO, Collegue>(creationColleguePostDTO);
            collegue.Matricule = Guid.NewGuid();
            _data.Add(collegue.Matricule.ToString(), collegue);
            return collegue;
        }
    }
}
