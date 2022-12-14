using Core.Entities.Concrete;
using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {

        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);

        void Add(User user);
        IDataResult<List<User>> GetAll();

    }
}
