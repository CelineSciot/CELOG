using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using CELOG.Models;
using CELOG.Filters;

namespace CELOG.Controllers
{
    public class HistoriqueController : ApiController
    {
       
        public IEnumerable<Historique> GetAllProduit()
        {
            return HistoriqueDAO.GetAllHistoriques();
        }

       
        public List<Historique> Get(int id)
        {
            return HistoriqueDAO.Get(id);
        }

       
        public Historique Post(Historique histo)
        {
            return HistoriqueDAO.Create(histo);
        }
       
    }
}
    

