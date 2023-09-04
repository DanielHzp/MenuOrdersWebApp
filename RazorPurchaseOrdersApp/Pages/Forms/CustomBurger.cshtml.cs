using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPurchaseOrdersApp.Models;

namespace RazorPurchaseOrdersApp.Pages.Forms
{

    //View model
    public class CustomBurgerModel : PageModel
    {
        //Data binding between burger model and custom burger razor page view

        [BindProperty]


         //Main Class object reference (burger model)
        public BurgersModel Burger { get; set; }
        

        
    }
}
