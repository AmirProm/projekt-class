using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.interfaces;
using api.model;
using api.Settings;
using MongoDB.Driver;

namespace api.Repositories;

public class AccountRepository : IAccountRepository
{
        private readonly IMongoCollection<Appuser> _collection;

    // Dependency Injection
    public AccountRepository(IMongoClient client, IMongoDbSettings dbSettings)
    {
        var dbName = client.GetDatabase(dbSettings.DatabaseName);
        _collection = dbName.GetCollection<Appuser>("users");
    }

    public Task<Appuser> GetAllAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<Appuser> RegisterAsync(Appuser userInput, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
