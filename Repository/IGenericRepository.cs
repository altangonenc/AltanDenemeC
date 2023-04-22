using System.Runtime.CompilerServices;
using AltanDenemeC.Models;
using System.Collections.Generic;

namespace AltanDenemeC.Repository
{
    public interface IGenericRepository<T> where T : class , new() {
        // Generic repo olması için T koyabiliriz. İsme takilma
        // T newlenebilir bir class olmali.
        T Add(T entity);
        T Delete(T entity);
        T GetById(int id);
        List<T> GetAll();
        T UpdateById(T entity, int id);        
    }
}