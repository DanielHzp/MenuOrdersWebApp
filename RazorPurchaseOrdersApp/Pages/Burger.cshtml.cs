using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPurchaseOrdersApp.Models;

namespace RazorPurchaseOrdersApp.Pages
{
    public class BurgerModel : PageModel
    {
        //Class Reference of burgers data model
        //Creates a list of all burger model objects that will be obtained from the database
        public List<BurgersModel> menuDatabase = new List<BurgersModel>()
        {
            //Populate records data in the list:
            new BurgersModel(){
                ImageTitle="Campereada",
                Name="Campereada",
                UnitPrice=12,
                HouseSauce=true,
                DoubleMeat=true,
                FinalPrice=17 },

             new BurgersModel(){
                ImageTitle="Charrua",
                Name="Charrua",
                UnitPrice=16,
                HouseSauce=true,
                Cheese=true,
                HouseVeggies=true,
                SingleMeat=true,
                ExtraBacon=false,
                RazorVeggieToppings=false,
                FinalPrice=19 },

              new BurgersModel(){
                ImageTitle="Fritz",
                Name="Fritz",
                UnitPrice=18,
                HouseSauce=true,
                Cheese=true,
                HouseVeggies=true,
                SingleMeat=true,
                ExtraBacon=false,
                RazorVeggieToppings=true,
                FinalPrice=22 },

               new BurgersModel(){
                ImageTitle="Garibaldi",
                Name="Garibaldi",
                UnitPrice=23,
                HouseSauce=true,
                Cheese=true,
                HouseVeggies=true,
                SingleMeat=false,
                DoubleMeat=true,
                ExtraBacon=true,
                RazorVeggieToppings=true,
                FinalPrice=28 },

                new BurgersModel(){
                ImageTitle="Lacador",
                Name="Lacador",
                UnitPrice=20,
                HouseSauce=true,
                Cheese=true,
                HouseVeggies=true,
                SingleMeat=false,
                DoubleMeat=true,
                ExtraBacon=false,
                RazorVeggieToppings=false,
                FinalPrice=26 },


                 new BurgersModel(){
                ImageTitle="LaPlata",
                Name="LaPlata",
                UnitPrice=18,
                HouseSauce=false,
                Cheese=true,
                HouseVeggies=true,
                SingleMeat=false,
                DoubleMeat=true,
                ExtraBacon=false,
                RazorVeggieToppings=false,
                FinalPrice=25 },


                 new BurgersModel(){
                ImageTitle="Macanudo",
                Name="Macanudo",
                UnitPrice=23,
                HouseSauce=true,
                Cheese=true,
                HouseVeggies=true,
                SingleMeat=false,
                DoubleMeat=false,
                ExtraBacon=false,
                RazorVeggieToppings=true,
                FinalPrice=32 },

                   new BurgersModel(){
                ImageTitle="Pampa",
                Name="Pampa",
                UnitPrice=15,
                HouseSauce=true,
                Cheese=true,
                HouseVeggies=true,
                SingleMeat=true,
                DoubleMeat=false,
                ExtraBacon=false,
                RazorVeggieToppings=true,
                FinalPrice=20 },

                 new BurgersModel(){
                ImageTitle="Piratini",
                Name="Piratini",
                UnitPrice=15,
                HouseSauce=true,
                Cheese=true,
                HouseVeggies=true,
                SingleMeat=true,
                DoubleMeat=true,
                ExtraBacon=false,
                RazorVeggieToppings=false,
                FinalPrice=30 },


        };
        public void OnGet()
        {
        }
    }
}
