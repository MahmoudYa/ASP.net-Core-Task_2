using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temp.Data;
using Temp.Objects.Models;

namespace Temp.Services
{
    public class CustomerLocationService : AService
    {
        public CustomerLocationService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
        public List<Country> GetCountries()
        {
            return new List<Country>
            {
        new Country { Id = 1, Name = "A" },
        new Country { Id = 2, Name = "B" }
        };
        }

        public List<State> GetStates()
        {
            return new List<State>
        {
            new State { Id = 1, Name = "S1", CountryId=1 },
            new State { Id = 2, Name = "S2", CountryId=1 },
            new State { Id = 3, Name = "S3", CountryId=1 },
            new State { Id = 4, Name = "S4", CountryId=1 },
            new State { Id = 5, Name = "S5", CountryId=2 },
            new State { Id = 6, Name = "S6", CountryId=2 }
        };
        }

    }
}
