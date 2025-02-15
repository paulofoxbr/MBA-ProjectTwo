using PCF.SPA.Services;
using PCF.SPA.Components.Orcamento;
using Microsoft.AspNetCore.Components;
namespace PCF.SPA.Pages.Reports
{
    public partial class RelatorioOrcamento
    {
        private IEnumerable<OrcamentoResponseViewModel> _orcamentos = new List<OrcamentoResponseViewModel>(); // Initialize the list
        private IEnumerable<TransacaoResponse> _transacao = new List<TransacaoResponse>(); // Initialize the list
        private bool _loading = true;
        private DateTime? _dataInicial = DateTime.Today.AddDays(-1);
        private DateTime? _dataFinal = DateTime.Today;

        [Inject] private IWebApiClient WebApiClient { get; set; } 
        [Inject] private IDialogService DialogService { get; set; } 
        [Inject] private ISnackbar Snackbar { get; set; } 

        protected override async Task OnInitializedAsync()
        {
           // await LoadOrcamentosAsync();
        }

        private async Task LoadOrcamentosAsync()
        {
            _loading = true;
            try
            {
                _orcamentos = await WebApiClient.OrcamentosAllAsync();

            }
            catch (Exception ex)
            {
                Snackbar.Add($"Erro não esperado: {ex.Message}", Severity.Error);
            }
            finally
            {
                _loading = false;
            }
        }
    }
}
