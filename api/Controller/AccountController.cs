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


}