using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: OwinStartup(typeof(PizzaStoreApi.client.Startup))]

namespace PizzaStoreApi.client
{
    public class Startup
    {
        public void Configuration(IAppBuilder builder)
        {
            builder.UseCookieAuthentication(new CookieAuthenticationOptions()
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                CookieName = "pizzadough",
                CookieHttpOnly = true,
                LoginPath = new PathString("/account/login"),
                LogoutPath = new PathString("/account/logout")
            });
        }
    }
}