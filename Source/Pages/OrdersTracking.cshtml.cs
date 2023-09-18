using Microsoft.AspNetCore.Mvc; 
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPurchaseOrdersApp.Database;
using RazorPurchaseOrdersApp.Models;

namespace RazorPurchaseOrdersApp.Pages
{
    //We want to display a table with all orders in our database
    //Show all data that has persisted 
    //Save and read persisted data
    public class Orders_TrackingModel : PageModel
    {
        public List<BurgerDBOrder> OrdersHistory = new List<BurgerDBOrder>();

        //We can use dependency injection by CREATING A CONSTRUCTOR

        private readonly ContextDBApp _InvokeDBContext;

        //Create constructor in order to use dependency injection
        public Orders_TrackingModel(ContextDBApp context)
        {
            _InvokeDBContext = context;
        }
        public void OnGet()
        {

            //Obtain info we need to display in a table
            OrdersHistory = _InvokeDBContext.MenuOrders.ToList();   

        }
    }
}
