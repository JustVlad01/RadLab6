
using DataModel;
using Microsoft.AspNetCore.Components;
using RAD302Week6BlazorClient2025.S00233992;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RAD302Week6BlazorClient2025.S00233992.Pages
{

    public partial class SupplierProducts
    {
        [Parameter]
        public int SupplierID { get; set; }

        public Supplier Current { get; set; }

        protected override Task OnInitializedAsync()
        {
            Current = SupplierStaticContext.GetNewSupplier(SupplierID);

            return base.OnInitializedAsync();
        }
    }
}
