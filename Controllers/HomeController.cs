using AutoFackExample.Business.Abstractions;
using AutoFackExample.Models.ClientEntities.Response;
using System.Collections.Generic;
using System.Web.Http;

namespace AutoFackExample.Controllers
{
    public class HomeController : ApiController
    {
        private readonly IExampleService _exampleSerive;

        public HomeController(IExampleService exampleService)
        {
            _exampleSerive = exampleService;
        }

        [HttpGet]
        public List<ExampleResponse> GetList()
        {
            return _exampleSerive.GetExample();
        }

        [HttpGet]
        public ExampleResponse GetDetail(int id)
        {
            return _exampleSerive.GetDetail(id);
        }
    }
}
