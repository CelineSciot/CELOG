﻿using System;
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
       
        public IEnumerable<Commande> GetAllCommandes()
        {
            return CommandeDAO.GetAllCommandes();
        }

       
        public Commande Get(int id)
        {
            return CommandeDAO.Get(id);
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
    
