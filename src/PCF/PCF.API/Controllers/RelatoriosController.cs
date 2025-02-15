using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;
using PCF.API.Controllers.Base;
using PCF.Core.Entities;
using PCF.Core.Interface;
using PCF.Core.Services;
using PCF.Shared.Dtos;

namespace PCF.API.Controllers;

[Route("api/relatorios")]
public class RelatoriosController(ITransacaoService TransacaoService) : ApiControllerBase
{


    [HttpGet]
    public async Task<Ok<IEnumerable<TransacaoResponse>>> GetOrcamentoRealizado()
    {
        var list = await TransacaoService.GetAllAsync();

        return TypedResults.Ok(list.Adapt<IEnumerable<TransacaoResponse>>());
    }
}
