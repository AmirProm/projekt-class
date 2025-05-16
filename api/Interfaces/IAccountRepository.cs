namespace api.interfaces;

public interface IAccountRepository
{
    public Task<Appuser?> RegisterAsync(Appuser userInput, CancellationToken cancellationToken);
    public Task<List<Appuser>?> GetAllAsync(CancellationToken cancellationToken);
}
