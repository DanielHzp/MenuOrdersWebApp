namespace RazorPurchaseOrdersApp.Models
{
    public class BurgersModel
    {
        public string ImageTitle { get; set; }   

        public string Name { get; set; }

        public float UnitPrice { get; set; } = 5;

        public bool HouseSauce { get; set; }

        public bool Cheese { get; set; }

        public bool HouseVeggies { get; set; }

        public bool SingleMeat { get; set; }

        public bool DoubleMeat { get;set; }

        public bool ExtraBacon { get; set; }

        public bool RazorVeggieToppings { get; set; }  


        public float FinalPrice { get; set; }




    }
}
