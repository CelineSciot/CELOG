using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using CELOG.Models;

namespace CELOG.Controllers
{
    public class CommandeController : ApiController
    {
       [System.Web.Http.Route("api/commande/admin")]
        public IEnumerable<Commande> GetAllCommandes()
        {
            return CommandeDAO.GetAllCommandes();
        }

       
        public IEnumerable<Commande> GetPanier(int id)
        {
            return CommandeDAO.GetPanier(id);
        }

        public Commande Post(Commande produit)
        {
            return CommandeDAO.Create(produit);
        }

        /*public string Put(Commande produit)
        {
            if (CommandeDAO.Update(produit))
            {
                return "ok-Put";
            }

            return "pas-Put";
        }*/

        public string Delete(int id)
        {
            if (CommandeDAO.Delete(id))
            {
                return "ok-Delete";
            }

            return "Pas-Delete";
        }
    }
}
    

