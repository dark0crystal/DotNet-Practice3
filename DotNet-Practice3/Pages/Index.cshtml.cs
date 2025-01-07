using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace DotNet_Practice3.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string selection { get; set; } = ""; // Use a more descriptive property name
        private List<string> arr = new List<string> { "oman", "qatar", "saudi", "united states", "united kingdoms", "syria" }; // Proper encapsulation

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnPost(string selection)
        {
            this.selection = selection; // Update the class property with the incoming selection value

            if (!string.IsNullOrEmpty(selection))
            {
                if (selection == "groupBy")
                {
                    // Group countries by their first letter and store the result in ViewData
                    var grouped = from i in arr
                        where i.StartsWith("o")
                            select i;

                    foreach (var i in grouped)
                    {
                        ViewData["data"] += i+"\n" ;

                    }
                    ViewData["message"] = $"You selected Get Number. Total countries: {grouped.Count()}";

                  
                }
                else if (selection == "getNum")
                {
                    // Display the total number of countries
                    var group = from n in arr
                        select n;
                    foreach (var i in group)
                    {
                        ViewData["data"] += i + "\n"; 
                    }
                   
                    ViewData["message"] = $"You selected Get Number. Total countries: {arr.Count}";
                }
                else
                {
                    ViewData["message"] = "Invalid selection.";
                }
            }
            else
            {
                ViewData["message"] = "Not a valid selection.";
            }
        }
    }
}