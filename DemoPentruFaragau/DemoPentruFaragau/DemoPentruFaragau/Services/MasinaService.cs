using DemoPentruFaragau.Repositories;
using System;
using System.Collections.Generic;

namespace DemoPentruFaragau.Services
{
    //Aici fac calcule in legatura cu clasa masina
    public class MasinaService
    {
        private MasinaRepository repo;

        public MasinaService()
        {
            repo = new MasinaRepository();
        }

        public List<Masina> GetAllCars()
        {
            List<Masina> masini = repo.GetAll();

            return masini;
        }

        public void AddNewCar(Masina masina)
        {
            repo.Add(masina);
        }
    }
}