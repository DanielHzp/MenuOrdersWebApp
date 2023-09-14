using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPurchaseOrdersApp.Models;

namespace RazorPurchaseOrdersApp.Pages
{
    //We want to display a table with all orders in our database
    //Show all data that has persisted 
    public class Orders_TrackingModel : PageModel
    {
        public List<BurgerDBOrder> OrdersHistory = new List<BurgerDBOrder>();
        public void OnGet()
        {
        }
    }
}
