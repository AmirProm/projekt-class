using api.interfaces;
using api.model;
using Microsoft.AspNetCore.Mvc;

namespace api.Controller;

[ApiController]
[Route("api/[controller]")]
public class AccountController(IAccountRepository accountRepository) : ControllerBase
{

    [HttpPost("Register")]
    public async Task<ActionResult<Appuser>> Register(Appuser userInput, CancellationToken cancellationToken)
    {
        Appuser? appuser = await accountRepository.RegisterAsync(userInput, cancellationToken);

        if (appuser is null)
            return BadRequest("email already.");

        return appuser;
    }

    [HttpGet("Get-all")]
    public async Task<ActionResult<List<Appuser>>> GetAll(CancellationToken cancellationToken)
    {
        List<Appuser>? appusers = await accountRepository.GetAllAsync(cancellationToken);

        if (appusers is null)
            return NoContent();

        return appusers;
    }


}