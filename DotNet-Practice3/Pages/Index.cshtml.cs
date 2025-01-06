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
            this.uname = uname; 
            this.pass=pass;
        } 
    } 
}

// ^ start with
// $ end with
// [] range 
// () group
// . single character once
// + one or more character in row 
// ? optional preceding character match
// \ escape character 
// \n new line 
// \d digit
// \D non-digit
// \s white space 
// \S non-white space
// \w alphanumeric / underscore character
// \W non-word characters
// {x,y} low(x) to high(y) (no y means at least x, )
// (x | y) alternative x or y 
// [^x] anything but x 