using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDemo.Models.Interfaces
{
    public interface ITechnology
    {
        Task<List<Technology>> GetTechnologies();
    }
}
