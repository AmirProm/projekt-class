using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.model;

namespace api.interfaces;

public interface IAccountRepository
{
    public Task<Appuser?> RegisterAsync(Appuser userInput, CancellationToken cancellationToken);
    public Task<Appuser?> GetAllAsync(CancellationToken cancellationToken);
}
