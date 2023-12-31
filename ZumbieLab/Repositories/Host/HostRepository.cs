﻿using ZombieLab.Data;
using ZombieLab.Models;

namespace ZombieLab.Repositories
{
    public class HostRepository : IHostRepository
    {
        private readonly DataBaseContext _dataBaseContext;

        public HostRepository(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        public HostModel Create(HostModel host)
        {
            host.SetAttributes();
            _dataBaseContext.Host.Add(host);
            _dataBaseContext.SaveChanges();
            return host;
        }

        public bool Delete(long id)
        {
            HostModel deleteHost = Get(id) ?? throw new Exception("Usuário inválido ou inexistente");

            _dataBaseContext.Remove(deleteHost);
            _dataBaseContext.SaveChanges();

            return true;
        }

        public HostModel Get(long id)
        {
            return _dataBaseContext.Host.FirstOrDefault(x => x.Id == id);
        }

        public List<HostModel> GetAll()
        {
            return _dataBaseContext.Host.ToList();
        }

        public HostModel Update(HostModel host)
        {
            HostModel updateHost = Get(host.Id) ?? throw new Exception("Hospedeiro inválido ou inexistente");

            updateHost.Age = host.Age;            
            updateHost.Gender = host.Gender;
            updateHost.Weight = host.Weight;
            updateHost.Height = host.Height;
            updateHost.BloodType = host.BloodType;
            updateHost.MusicalTaste = host.MusicalTaste;
            updateHost.SportPlayed = host.SportPlayed;
            updateHost.FavoriteGame = host.FavoriteGame;
            updateHost.SetAttributes();
            _dataBaseContext.Update(updateHost);
            _dataBaseContext.SaveChanges();
            return updateHost;
        }
    }
}