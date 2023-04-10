using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Generics
{
    public interface IGenerics <T> where T : class
    {
        Task Create(T Object);

        Task Upload(T Object);

        Task Delete(T Object);

        Task SearchById(int Id);

        Task<List<T>> List();
    }
}
