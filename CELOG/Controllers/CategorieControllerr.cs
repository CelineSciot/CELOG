using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using CELOG.Models;

namespace CELOG.Controllers
{
    public class CategorieController : ApiController
    {
       
        public IEnumerable<Categorie> GetAllCategorie()
        {
            return CategorieDAO.GetAllCategorie();
        }

       
        public Categorie Get(int id)
        {
            return CategorieDAO.Get(id);
        }

        public Categorie Post(Categorie categorie)
        {
            return CategorieDAO.Create(categorie);
        }

        public string Put(Categorie categorie)
        {
            if (CategorieDAO.Update(categorie))
            {
                return "ok-Put";
            }

            return "pas-Put";
        }

        public string Delete(int id)
        {
            if (CategorieDAO.Delete(id))
            {
                return "ok-Delete";
            }

            return "Pas-Delete";
        }
    }
}
    

