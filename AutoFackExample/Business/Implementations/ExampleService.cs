using AutoFackExample.Business.Abstractions;
using AutoFackExample.Data.Repository.Abstractions;
using AutoFackExample.Helpers;
using AutoFackExample.Models.ClientEntities.Response;
using System.Collections.Generic;

namespace AutoFackExample.Business.Implementations
{
    [Injectable]
    public class ExampleService : IExampleService
    {
        private readonly IExampleRepository _exampleRepository;

        public ExampleService(IExampleRepository exampleRepository)
        {
            _exampleRepository = exampleRepository;
        }

        public List<ExampleResponse> GetExample()
        {
            List<ExampleResponse> response = new List<ExampleResponse>();

            var list = _exampleRepository.GetExampleRepo();

            foreach (var item in list)
            {
                response.Add(new ExampleResponse() { id = item.id, name = item.Name, age = item.Age });
            }

            return response;
        }

        public ExampleResponse GetDetail(int id)
        {
            ExampleResponse response = new ExampleResponse();

            var value = _exampleRepository.GetDetail(id);

            if (value != null)
            {
                response.id = value.id;
                response.name = value.Name;
                response.age = value.Age;
            }

            return response;
        }
    }
}