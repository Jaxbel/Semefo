using SemefoApp.BL.Repositories;
using SemefoApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemefoApp.BL.Services
{
    public interface ICuerpoService
    {
        Task<List<CuerpoModel>> GetCuerpos();
    }
    public class CuerpoService(ICuerpoRepository cuerpoRepository) : ICuerpoService
    {
        public Task<List<CuerpoModel>> GetCuerpos()
        {
            return cuerpoRepository.GetCuerpos();
        }
    }
}
