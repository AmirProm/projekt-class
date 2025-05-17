namespace api.Controller;

[ApiController]
[Route("api/[controller]")]
public class AccountController(IAccountRepository accountRepository) : ControllerBase
{

    [HttpPost("register")]
    public async Task<ActionResult<Appuser?>> Register(Appuser userInput, CancellationToken cancellationToken)
    {
        Appuser? appuser = await accountRepository.RegisterAsync(userInput, cancellationToken);

        if (appuser is null)
            return BadRequest("email already.");

        return appuser;
    }

    [HttpGet("get-all")]
    public async Task<ActionResult<List<Appuser?>>> GetAll(CancellationToken cancellationToken)
    {
        List<Appuser>? appusers = await accountRepository.GetAllAsync(cancellationToken);

        if (appusers is null)
            return NoContent();

        return appusers;
    }
    
}