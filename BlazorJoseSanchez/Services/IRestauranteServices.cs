using BlazorJoseSanchez.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorJoseSanchez.Services
{
    public interface IRestauranteServices
    {
        Task<IEnumerable<Restaurante>> GetAllRestaurantes();
        Task<IEnumerable<Restaurante>> GetIDRestaurantes(int id);


    }
}
