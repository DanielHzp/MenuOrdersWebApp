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

        public float BurgerPrice { get; set; }

        //IActionResult method
        //Specify how a response is going to be given to a specific request
        //Catch anything submitted with the POST method  (OnPost)
        public IActionResult OnPost()
        {
            //Return response or error

            BurgerPrice = Burger.UnitPrice;

            //Set unit price increments based on boolean selection on this view
            if (Burger.HouseSauce) BurgerPrice += 1;
            if(Burger.Cheese) BurgerPrice += 1;
            if (Burger.HouseVeggies) BurgerPrice += 1;
            if (Burger.SingleMeat) BurgerPrice += 5;
            if (Burger.DoubleMeat) BurgerPrice += 15;
            if (Burger.ExtraBacon) BurgerPrice += 2;
            if (Burger.RazorVeggieToppings) BurgerPrice += 3;

            //Specify to which page to redirect and what attributes to pass
            return RedirectToPage("/Checkout/Checkout", new {Burger.Name, BurgerPrice });


        }

        

        
    }
}
