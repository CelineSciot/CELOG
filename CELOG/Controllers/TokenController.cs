﻿using System.Net;
using System.Web.Http;
using CELOG.Filters;
using CELOG.Models;

namespace CELOG.Controllers
{
    public class TokenController : ApiController
    {
        // THis is naive endpoint for demo, it should use Basic authentication to provdie token or POST request
        [AllowAnonymous]
        public string Get(string username, string password)
        {
            if (CheckUser(username, password))
            {
                return JwtManager.GenerateToken(username);
            }
            //throw new HttpResponseException(HttpStatusCode.Unauthorized);
            return "";
        }

        public bool CheckUser(string username, string password)
        {
            if (UtilisateurDAO.GetConnection(username, password))
            {
                return true;
            }
            return false;
        }
    }
}
