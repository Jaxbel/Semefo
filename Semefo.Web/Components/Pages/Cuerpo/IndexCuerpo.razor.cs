using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using SemefoApp.Models.Entities;

namespace Semefo.Web.Components.Pages.Cuerpo
{
    public partial class IndexCuerpo
    {
        [Inject]
        public ApiClient ApiClient { get; set; }
        public List<CuerpoModel> CuerpoModels { get; set; }

        protected override async Task OnInitializedAsync()
        {
            CuerpoModels = await ApiClient.GetCuerposAsync("/api/Cuerpo");
        }
    }
}