using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FacebookImages.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        [Produces("text/html")]
        public string Get()
        {
          return "<!DOCTYPE html>< html lang = \"en\"> <head>< meta charset = \"utf -8\">"+
                   "<meta http - equiv = \"X-UA-Compatible\" content = \"IE =Edge,chrome=1\" >"+
           "< meta name =  \"viewport\" content =  \"width =device-width, initial-scale=1.0\" > " +
              "< title > Kamasutra </ title > "+
              "< link rel = 'stylesheet' id = 'estilos'  href = 'estilos.css' type = 'text/css' media = 'all' > "+
                       "< meta property =  \"og: type\" content =  \"article\" > " +
                          "< meta property =  \"og: title\" content =  \"El pulpo \" > " +
                             "< meta property =  \"og:description \" content =  \"Placeres subacuáticos. \" > " +
                                "< meta property =  \"og:image \" content =  \"http://kamasutra.motelmaracay.com/img/elpulpo.png \" > " +
                                  "< meta name =  \"csrf-param \" content =  \"authenticity_token \" > " +
                                  "</head><body></body></html>";
        }

    // GET api/values/5
    [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
