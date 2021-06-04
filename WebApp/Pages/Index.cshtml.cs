using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Api;
using WebApp.Models;

namespace WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IProductEndpoint _productEndpoint;


        #region PROPERTIES
        public IEnumerable<ProductModel> Products { get; set; }
        #endregion

        public IndexModel(ILogger<IndexModel> logger, IProductEndpoint productEndpoint)
        {
            _logger = logger;
            _productEndpoint = productEndpoint;
        }

        public async Task OnGetAsync()
        {
            Products = await _productEndpoint.GetAllProducts();
        }

    }
}
