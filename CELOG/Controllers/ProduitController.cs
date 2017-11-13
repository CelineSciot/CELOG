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

        public Produit Post(Produit todo)
        {
            return ProduitDAO.Create(todo);
        }

        public IHttpActionResult Put(Produit todo)
        {
            if (ProduitDAO.Update(todo))
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
