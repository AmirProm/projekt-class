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

    #region 
    private readonly IMongoCollection<Appuser> _collection;

    public AccountRepository(IMongoClient client, IMongoDbSettings dbSettings)
    {
        var dbName = client.GetDatabase(dbSettings.DatabaseName);
        _collection = dbName.GetCollection<Appuser>("users");
    }
    #endregion

    public async Task<Appuser> GetAllAsync(CancellationToken cancellationToken)
    {

    }

    public async Task<Appuser?> RegisterAsync(Appuser userInput, CancellationToken cancellationToken)
    {
        Appuser user = await _collection.Find<Appuser>(doc =>
        doc.email == userInput.email).FirstOrDefaultAsync(cancellationToken);

        if (user is not null)
            return null;

        await _collection.InsertOneAsync(userInput, null, cancellationToken);

        return user;
    }
}
