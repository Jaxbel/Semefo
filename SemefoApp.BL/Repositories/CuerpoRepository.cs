using Microsoft.EntityFrameworkCore;
using SemefoApp.BL.Services;
using SemefoApp.Database.Data;
using SemefoApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemefoApp.BL.Repositories
{
    public interface ICuerpoRepository
    {
        Task<List<CuerpoModel>> GetCuerpos();
    }
    public class CuerpoRepository(AppDbContext dbContext) : ICuerpoRepository
    {
        public Task<List<CuerpoModel>> GetCuerpos()
        {
            return dbContext.Cuerpos.ToListAsync();
        }
    }
}
