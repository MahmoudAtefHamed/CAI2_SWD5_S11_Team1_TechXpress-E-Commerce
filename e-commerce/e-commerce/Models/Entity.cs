using Microsoft.EntityFrameworkCore;

namespace e_commerce.Models
{
    public class Entity:DbContext
    {
        
        public DbSet<Address>? Addresses { get; set; }
        public DbSet<Country>? Countries { get; set; }
        public DbSet<Order_Line>? OrderLines { get; set; }
        public DbSet<Order_Status>? OrderStatuses { get; set; }
        public DbSet<Payment_Type>? PaymentTypes { get; set; }
        public DbSet<Product>? Products { get; set; }
        public DbSet<Product_Category>? ProductCategories { get; set; }
        public DbSet<Product_Configuration>? ProductConfigurations { get; set; }
        public DbSet<Product_Item>? ProductItems { get; set; }
        public DbSet<Promotion>? Promotions { get; set; }
        public DbSet<Promotion_Category>? PromotionCategories { get; set; }
        public DbSet<Review>? Reviews { get; set; }
        public DbSet<Shipping_Method>? ShippingMethods { get; set; }
        public DbSet<Shop_Order>? ShopOrders { get; set; }
        public DbSet<Shopping_Cart>? ShoppingCarts { get; set; }
        public DbSet<Shopping_Cart_Item>? ShoppingCartItems { get; set; }
        public DbSet<Site_User>? SiteUsers { get; set; }
        public DbSet<User_Address>? UserAddresses { get; set; }
        public DbSet<User_Payment_Method>? UserPaymentMethods { get; set; }
        public DbSet<Variation>? Variations { get; set; }
        public DbSet<Variation_Option>? VariationOptions { get; set; }

        public Entity() : base()
        {

        }
        public Entity(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //options 
            optionsBuilder.UseSqlServer("Server=DESKTOP-MV2T7M8\\SQLEXPRESS;Database=DEPIDataBase;Trusted_Connection=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
