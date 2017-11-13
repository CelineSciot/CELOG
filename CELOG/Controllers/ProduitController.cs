using CELOG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CELOG.Controllers
{
    public class ProduitController : ApiController
    {
        //http://127.0.0.1:8080/api/todo
        public IEnumerable<Produit> GetAllProduit()
        {
            return ProduitDAO.GetAllProduit();
        }

        //http://127.0.0.1:8080/api/todo?id=5
        public Produit Get(int id)
        {
            return ProduitDAO.Get(id);
        }

        public Produit Post(Produit produit)
        {
            return ProduitDAO.Create(produit);
        }

        public IHttpActionResult Put(Produit produit)
        {
            if (ProduitDAO.Update(produit))
            {
                return Ok();
            }

            return BadRequest();
        }

        public IHttpActionResult Delete(int id)
        {
            if (ProduitDAO.Delete(id))
            {
                return Ok();
            }

            return BadRequest();
        }
    }
}
    }
}
