using Data.DbContext;
using Data.IRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    internal class AllRepositories<KEntities> : IAllRepositories<KEntities> where KEntities : class
    {
        private readonly AppDbContext context;
        DbSet<KEntities> Entities { get; set ; } // Tạo 1 DBSet 
        DbSet<KEntities> IAllRepositories<KEntities>.Entities { get; set ; }
        public AllRepositories()
        {

        }
        public AllRepositories(AppDbContext context)
        {
            this.context = context;
            //this.Entities = Entities;
        }

        public bool AddManyAsync(IEnumerable<KEntities> entity)
        {
            try
            {
                Entities.AddRange(entity); return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AddOneAsync(KEntities entity)
        {
            try
            {
                Entities.Add(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
  
            }
        }

        public bool DeleteManyAsync(IEnumerable<KEntities> entity)
        {
            try
            {
                Entities.RemoveRange(entity); return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteOneAsync(KEntities entity)
        {
            try
            {
                Entities.Remove(entity); return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<IEnumerable<KEntities>> GetAllAsync()
        {
            return await Entities.ToListAsync(); // Lấy tất cả ra từ DBSet
        }

        public async Task<KEntities> GetOneAsync(IKey key)
        {
            return await Entities.FindAsync(key); // Dùng find để tìm
        }

        public bool UpdateManyAsync(IEnumerable<KEntities> entity)
        {
            try
            {
                Entities.UpdateRange(entity); return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateOneAsync(KEntities entity)
        {
            try
            {
                Entities.Update(entity); return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
