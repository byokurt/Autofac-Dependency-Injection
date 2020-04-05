using AutoFackExample.Data.Repository.Abstractions;
using AutoFackExample.Helpers;
using AutoFackExample.Models.BusinessEntities;
using System.Collections.Generic;
using System.Linq;

namespace AutoFackExample.Data.Repository.Implementations
{

    [Injectable]
    public class ExampleRepository : IExampleRepository
    {
        public List<ExampleModel> GetExampleRepo()
        {
            using (DataContext entities = new DataContext())
            {
                return entities.ExampleModel.ToList();
            }
        }

        public ExampleModel GetDetail(int id)
        {
            using (DataContext entities = new DataContext())
            {
                return entities.ExampleModel.Where(w => w.id == id).FirstOrDefault();
            }
        }
    }
}