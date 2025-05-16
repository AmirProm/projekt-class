using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.interfaces;
using api.model;

namespace api.Repositories;

public class AccountRepository : IAccountRepository
{
    public Task<Appuser> GetAllAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<Appuser> RegisterAsync(Appuser userInput, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
