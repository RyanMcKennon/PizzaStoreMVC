using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using PizzaStoreApi.client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web;
using System.Web.Http;

namespace PizzaStoreApi.client.Controllers
{
    public class AccountController : ApiController
    {
        private static UserStore<IdentityUser> credentials = new UserStore<IdentityUser>(new AccountModel());
        private UserManager<IdentityUser> manager = new UserManager<IdentityUser>(credentials);


        public HttpResponseMessage Post([FromBody] UserAccount account)
        {
            var user = new IdentityUser() { UserName = account.Username };

            var result = manager.Create(user, account.password);
            if (result.Succeeded)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }

            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }

        public HttpResponseMessage Delete(string user)
        {
            var u = manager.FindByName(user);
            var result = manager.Delete(u);
            if (result.Succeeded)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }

            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }

        public HttpResponseMessage Login([FromBody]UserAccount account )
        {
            var u = manager.FindByName(account.Username);

            if(u == null)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            // todo

            var auth = HttpContext.Current.GetOwinContext().Authentication;
            var id = manager.CreateIdentity(u,DefaultAuthenticationTypes.ApplicationCookie);

            
            auth.SignIn();

            return Request.CreateResponse(HttpStatusCode.OK);

        }

        public HttpResponseMessage Logout()
        {
            //todo
            var auth = HttpContext.Current.GetOwinContext().Authentication;
            auth.SignOut();

            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
