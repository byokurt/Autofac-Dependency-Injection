using AutoFackExample.Models.ClientEntities.Response;
using System.Collections.Generic;

namespace AutoFackExample.Business.Abstractions
{
    public interface IExampleService
    {
        List<ExampleResponse> GetExample();

        ExampleResponse GetDetail(int id);
    }
}