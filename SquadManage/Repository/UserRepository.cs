using Repository.Context;
using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    // vai fazer o crud, seria o DAO
    public class UserRepository:IUserRepository

    {

          protected EFContext _dataContext;
        public UserRepository(EFContext dataContext) { 
            _dataContext = dataContext;
        }
        public void Add(UserEntity entity) {
            this._dataContext.Users.Add(entity);
            //this._dataContext.Users.SaveChanges();
        }
    }
}
