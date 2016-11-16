using PizzaStoreApi.client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaStoreApi.client.Controllers
{
    public class CustomerController : ApiController
    {

        //public string Get(int id)
        //{
        //    return (new Customer() { Name = new Name() { First = "fred", Last = "belotte" } }).Name.ToString();
        //}


        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse<Customer>(HttpStatusCode.OK, new Customer());
        }

        //public HttpResponseMessage Get()
        //{
        //    //return Request.CreateResponse<Customer>(HttpStatusCode.OK, new List<string> { "a", "b", "c" });
        //    return;
        //}

        public bool Post(int id)
        {
            return false;
        }

        public string Post([FromBody]Name name)
        {
            return name.ToString();
        }

        public string Put([FromBody]Name name)
        {
            return name.ToString();
        }

        public string Delete(int id)
        {
            return "done";
        }
    }
}
