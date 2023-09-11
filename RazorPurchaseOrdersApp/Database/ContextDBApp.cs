//Call database context entityframework core sql server
using Microsoft.EntityFrameworkCore;
using RazorPurchaseOrdersApp.Models;



namespace RazorPurchaseOrdersApp.Database
{
    //Inherite dbContext instance to query and save instances of queries
    public class ContextDBApp : DbContext
    {
        //DbSet is a Table inside database model
        public DbSet<BurgerDBOrder> MenuOrders { get; set; }


        //Call inherited base constructor of DbContext
        //Used to configure connection string to SQL data base
        public ContextDBApp(DbContextOptions<ContextDBApp> options) 
            : base(options)
        {
                
        }
    }
}
