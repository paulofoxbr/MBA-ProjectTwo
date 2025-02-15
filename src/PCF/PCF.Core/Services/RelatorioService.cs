using PCF.Core.Interface;
using PCF.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCF.Core.Services
{
    public class RelatorioService : IRelatorioService
    {
        public Task<IEnumerable<RelatorioOrcamentoResponse>> GetOrcamentoRealizado(DateTime dataIncial, DateTime dataFinal)
        {
            throw new NotImplementedException();
        }
    }
}
