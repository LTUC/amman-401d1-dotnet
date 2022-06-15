using RazorPagesDemo.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RazorPagesDemo.Services.Interfaces
{
    public interface IPerson
    {
        Task<Person> Create(Person person);
        Task<List<Person>> GetAll();
    }
}
