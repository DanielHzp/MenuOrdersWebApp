using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPurchaseOrdersApp.Database;
using RazorPurchaseOrdersApp.Models;

namespace RazorPurchaseOrdersApp.Pages.Checkout
{

    //Data binding property for the entire class
    [BindProperties(SupportsGet =true)]
    public class CheckoutModel : PageModel
    {

      
        //These properties become accesible in the page view with BindProperties declaration
        public string burgerName { get; set; }
        public float BurgerPrice { get; set; }
        public string ImageName { get; set; }
        //THESE ATTRIBUTES MUST BE SAVED TO DATA BASE CREATED (MIGRATED)
        //DEPENDENCY INJECTION

        private readonly ContextDBApp _currentContext;



        //Create constructor to inject via dependency injection
        public CheckoutModel(ContextDBApp context)
        {
            //Context is the value of the dependency injection
            _currentContext = context;  //Context represents our database
        }

        //Get data
        public void OnGet()
        {
            if(string.IsNullOrWhiteSpace(burgerName))
            {
                burgerName = "Razor Default Burger";
            }
            if(string.IsNullOrWhiteSpace(ImageName))
            {
                ImageName = "Create";
            }
            //Every services declared in program.cs will be provided by dependency injection
            //BurgerDBOrder contains the data model database attributes
            BurgerDBOrder burgerOrderObject=new BurgerDBOrder(); ;

            //Assign values from current page model to database class attributes
            burgerOrderObject.BurgerDBName= burgerName;

            burgerOrderObject.FinalDBPrice = BurgerPrice;

            // Entity framework automatically creates primary key
            //Save burger order object in entity of instance of our database:

            _currentContext.MenuOrders.Add(burgerOrderObject);
            _currentContext.SaveChanges();






        }
    }
}
