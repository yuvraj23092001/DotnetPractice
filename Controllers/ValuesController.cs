using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleApp.Controllers
{
    
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [Route("api/get-all")]
        public string GetAll()
        {
            return "Hello from get all";
        }

        [Route("api/get-all-authors")]
        public string GetAllAuthors() 
        {
            return "Hello from get all Authors";
        }

        [Route("books/{id}")]
        public string GetAuthorsId(int id)
        {
            return "hello from " + id;
        }
    }
}
