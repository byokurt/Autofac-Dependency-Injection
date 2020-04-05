using AutoFackExample.Models.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoFackExample.Data.Repository.Abstractions
{
    public interface IExampleRepository
    {
        List<ExampleModel> GetExampleRepo();
        ExampleModel GetDetail(int id);
    }
}