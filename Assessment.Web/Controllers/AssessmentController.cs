using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Assessemet.Business;

namespace Assessment.Web.Controllers
{
    public class AssessmentController : ApiController
    {

        private databaseContext _dbContext;
        private ConsoleUtility _consoleUtil;

        public AssessmentController()
        {
            _dbContext = new databaseContext();
            _consoleUtil = new ConsoleUtility(MediaType.Console);
            
        }

        // GET: api/Assessement
        public HttpResponseMessage Get()
        {

            HttpResponseMessage response = null;
            var value = "";
            try
            {
                if (ModelState.IsValid)
                {

                    //  value.CustomerId = 11;
                    value = "Hello Word from API.";

                    response = Request.CreateResponse(HttpStatusCode.Created, value);
                }
            }
            catch (Exception ex)
            {

                var message = ex.Message;
                response = Request.CreateResponse(HttpStatusCode.BadRequest);
            }

           return response;     
        }

        //public string Get()
        //{

        //    HttpResponseMessage response = null;
        //    var  value = "Hello Word from API.";
            
        //    return value;

            
        //}

        /// <summary>
        /// For Conslose Message you may not need  HttpResponseMessage, at least for testing
        /// </summary>
        /// <returns></returns>
        [ActionName("setConsoleMessage")]
        public string SetConsoleMessage()
        {
            
            string response = null;
            var value = "Hello Word from API for Console.";

            return value;


        }


        // GET: api/Assessement/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Assessement
        public HttpResponseMessage Post([FromBody]string value)
        {
            HttpResponseMessage response = null;
            try
            {
                if (ModelState.IsValid)
                {
                    var temp = value;

                    // Use DI and get object to write to the database.
                    //Install UNITY or other IoC container to satify the requirement
                    value = "Hello Word from API.";

                    response = Request.CreateResponse(HttpStatusCode.Created, value);
                }
            }
            catch (Exception ex)
            {

                var message = ex.Message;
                response = Request.CreateResponse(HttpStatusCode.BadRequest);
            }


            return response;
        }

        // PUT: api/Assessement/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Assessement/5
        public void Delete(int id)
        {
        }
    }
}
