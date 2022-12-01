using System.Collections.Generic;
using System.Web.Http;
using TestimonyCS.Models;
using System.Web.Http.Cors;

namespace TestimonyCS.Controllers
{
    [EnableCors(origins: "http://mywebclient.azurewebsites.net", headers: "*", methods: "*")]
    public class TestimonyController : ApiController
    {
        // GET: api/Testimony
        //Returns a list of all testimonies
        public List<Rootobject> Get()
        {
            var json = DB.GetDB();
            return DB.GetDB();
        }                     
    }
}
