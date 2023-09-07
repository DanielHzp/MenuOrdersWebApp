using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPurchaseOrdersApp.Pages.Checkout
{

    //Data binding property for the entire class
    [BindProperties(SupportsGet =true)]
    public class CheckoutModel : PageModel
    {

      

        public string burgerName { get; set; }
        public float BurgerPrice { get; set; }
        public string ImageName { get; set; }



        //Get data
        public void OnGet()
        {
        }
    }
}
