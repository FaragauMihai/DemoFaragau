using DemoPentruFaragau;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoPentruFaragau.Repositories
{
    //Aici tin lista de masini si functii legate de lista aia cum ar fi add, delete, etc
    public class MasinaRepository
    {
        private masiniEntities dbContext;

        public MasinaRepository()
        {
            dbContext = new masiniEntities();
        }

        public List<Masina> GetAll()
        {
            var lista = dbContext.Masinas.ToList();
            return lista;
        }

        public void Add(Masina carToAdd)
        {
            dbContext.Masinas.Add(carToAdd);

            dbContext.SaveChanges();
        }
    }
}