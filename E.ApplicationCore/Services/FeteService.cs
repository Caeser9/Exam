using E.ApplicationCore.Domain;
using E.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.ApplicationCore.Services
{
    internal class FeteService : Service<Fete>, IFeteServices
    {
        public FeteService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public int FeteByTypeAndSalle(TypeFete typeF, Salle salleF)
        {
            return GetAll()
                .Where(f => f.Type == typeF && f.salle==salleF)
                .Count();
        }

        public int PlusLongAnniversaire()
        {
            return GetAll()
                .Where(f => f.Type == TypeFete.Anniversaire)
                .OrderByDescending(f => f.Duree).First().Duree;
                ;
        }
    }
}
