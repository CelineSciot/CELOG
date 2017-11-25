using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using CELOG.Models;

namespace CELOG.Controllers
{
    public class ProduitController : ApiController
    {
       
        public IEnumerable<Produit> GetAllProduit()
        {
            return ProduitDAO.GetAllProduit();
        }

       
        public Produit Get(int id)
        {
            return ProduitDAO.Get(id);
        }

        public IEnumerable<string> GetCategorie(string categ)
        {
            return ProduitDAO.GetCategorie();
        }

        public Produit Post(Produit produit)
        {
            return ProduitDAO.Create(produit);
        }

        public string Put(Produit produit)
        {
            if (ProduitDAO.Update(produit))
            {
                return "ok-Put";
            }

            return "pas-Put";
        }

        public string Delete(int id)
        {
            if (ProduitDAO.Delete(id))
            {
                return "ok-Delete";
            }

            return "Pas-Delete";
        }
    }
}
    

