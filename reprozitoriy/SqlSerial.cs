using System;
using WebApplication6черников.Новая_папка;

namespace WebApplication6черников.reprozitoriy
{
    public class SqlSerial : Iserial
    {
        private readonly adb _appDbContext;

        public SqlSerial(adb appDbContext)
        {
            _appDbContext = appDbContext;
        }
        Seriali Iserial.Add(Seriali seriali)
        {
          
        }

        Seriali Iserial.Dell(int id)
        {
            var user = GetUserById(id);
            _appDbContext.Remove(user);
            _appDbContext.SaveChanges();
            return user;
        }

        Seriali Iserial.Get(int id)
        {
            return _appDbContext.Serialis.Where(u => u.id == id).ToList().FirstOrDefault();
        }

        List<Seriali> Iserial.GetAll()
        {
            return _appDbContext.Serialis.ToList();
        }

        Seriali Iserial.Update(Seriali seriali)
        {
            if (seriali.id == 0)
            {
                _appDbContext.Serialis.Add(seriali);
            }
            else
            {
                _appDbContext.Serialis.Update(seriali);
            }
            _appDbContext.SaveChanges();
            return seriali;
        }
    }
}
