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

public async Task<Appuser?> RegisterAsync(Appuser userInput, CancellationToken cancellationToken)
    {
        Appuser user = await _collection.Find<Appuser>(doc =>
        doc.Email == userInput.Email).FirstOrDefaultAsync(cancellationToken);

        if (user is not null)
            return null;

        await _collection.InsertOneAsync(userInput, null, cancellationToken);

        return userInput;
    }

     public async Task<List<Appuser>?> GetAllAsync(CancellationToken cancellationToken)
    {
        List<Appuser> AppUsers = await _collection.Find(new BsonDocument()).ToListAsync(cancellationToken);

        if (AppUsers.Count == 0)
            return null;

        return AppUsers;
    }
}

    // public async Task<List<Appuser>?> GetAllAsync(CancellationToken cancellationToken)
    // {
    //     List<Appuser> AppUsers = await _collection.Find(new BsonDocument()).ToListAsync(cancellationToken);

    //     if (AppUsers.Count == 0)
    //         return null;

    //     return AppUsers;
    // }