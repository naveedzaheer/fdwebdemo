using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace fdwebdemo.Pages
{
    public class IndexModel : PageModel
    {
        public string Location { get; set;}
        private IConfigurationRoot ConfigRoot;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(IConfiguration configRoot, ILogger<IndexModel> logger)
        {
            _logger = logger;
            ConfigRoot = (IConfigurationRoot)configRoot;
        }

        public void OnGet()
        {
            Location = ConfigRoot["Location"];
        }
    }
}
