using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNet_Practice3.Pages {
    public class IndexModel : PageModel {
        private readonly ILogger<IndexModel> _logger;
        public string uname = "";
        public string pass = "";

        public IndexModel(ILogger<IndexModel> logger){
            _logger = logger;
        }
        public void OnPost (string uname,string pass)
        {
            this.uname = uname; this.pass=pass;
        } 
    } 
}