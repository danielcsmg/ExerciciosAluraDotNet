using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UsuariosApi.Data.Dtos;
using UsuariosApi.Services;

namespace UsuariosApi.Controllers;

[ApiController]
[Route("[Controller]")]
public class UsuarioController : ControllerBase
{
    public UsuarioService _cadastroService;

    public UsuarioController(UsuarioService cadastroService)
    {
        _cadastroService = cadastroService;
    }

    [HttpPost("cadastro")]
    public async Task<IActionResult> CadastrarUsuario(CreateUsuarioDto dto)
    {
        await _cadastroService.Cadastra(dto);

        return Ok("Usuário cadastrado com sucesso!");
    }

    [HttpPost("login")]
    public async Task<IActionResult> LoginUsuario(LoginUsuarioDto dto)
    {
        var token = await _cadastroService.Login(dto);


        return Ok(token);
    }

    [HttpGet]
    [Authorize(Policy = "IdadeMinima")]
    public IActionResult Get()
    {
        return Ok("Acesso autorizado!");
    }
}
