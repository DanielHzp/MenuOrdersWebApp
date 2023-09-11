namespace RazorPurchaseOrdersApp.Models
{
    public class BurgerDBOrder
    {
        //Primary Key SQL
        public int Id { get; set; }

        public string BurgerDBName { get; set; }

        public float FinalDBPrice { get; set; }

        //Application DB context
    }
}
