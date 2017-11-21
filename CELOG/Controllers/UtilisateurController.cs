﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using CELOG.Models;

namespace CELOG.Controllers
{
    public class UtilisateurController : ApiController
    {
       
        public IEnumerable<Utilisateur> GetAllUtilisateur()
        {
            return UtilisateurDAO.GetAllUtilisateur();
        }

       
        public Utilisateur Get(int id)
        {
            return UtilisateurDAO.Get(id);
        }

        public Utilisateur Post(Utilisateur utilisateur)
        {
            return UtilisateurDAO.Create(utilisateur);
        }

        public IHttpActionResult Put(Utilisateur utilisateur)
        {
            if (UtilisateurDAO.Update(utilisateur))
            {
                return Ok();
            }

            return BadRequest();
        }

        public IHttpActionResult Delete(int id)
        {
            if (UtilisateurDAO.Delete(id))
            {
                return Ok();
            }

            return BadRequest();
        }
    }
}
    
