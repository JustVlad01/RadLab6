using DataModel;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using RAD302Week6BlazorClient2025.S00233992;

namespace RAD302Week6BlazorClient2025.S00233992.Pages
{
    public partial class SupplierView
    {
        [Inject]
        public HttpClient Http { get; set; }

        private Supplier[] suppliers;

        protected override async Task OnInitializedAsync()
        {
            // Loading page for the first time
            if (SupplierStaticContext.Suppliers == null)
            {
                SupplierStaticContext.Suppliers =
                    suppliers = await Http.GetFromJsonAsync<Supplier[]>("sample-data/Supplier.json");
                SupplierStaticContext.Products = await Http.GetFromJsonAsync<Product[]>("sample-data/Product.json");
                InitialiseSupplierProducts();
            }
            else // We are reloading the page
            {
                suppliers = SupplierStaticContext.Suppliers;
                await base.OnInitializedAsync();
            }
        }

        private void InitialiseSupplierProducts()
        {
            foreach (var item in suppliers)
            {
                List<Product> toadd =
                    SupplierStaticContext.Products.OrderBy(o => new Random().Next(2372))
                    .Take(3).ToList();
                item.SupplierProducts = new List<Product>();
                item.SupplierProducts.AddRange(toadd);
            }
        }
    } 
}