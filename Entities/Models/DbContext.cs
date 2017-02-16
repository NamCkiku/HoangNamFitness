namespace Entities.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
        }

        public virtual DbSet<AclRecord> AclRecords { get; set; }
        public virtual DbSet<ActivityLog> ActivityLogs { get; set; }
        public virtual DbSet<ActivityLogType> ActivityLogTypes { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<AddressAttribute> AddressAttributes { get; set; }
        public virtual DbSet<AddressAttributeValue> AddressAttributeValues { get; set; }
        public virtual DbSet<Affiliate> Affiliates { get; set; }
        public virtual DbSet<BackInStockSubscription> BackInStockSubscriptions { get; set; }
        public virtual DbSet<BlogComment> BlogComments { get; set; }
        public virtual DbSet<BlogPost> BlogPosts { get; set; }
        public virtual DbSet<Campaign> Campaigns { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CategoryTemplate> CategoryTemplates { get; set; }
        public virtual DbSet<CheckoutAttribute> CheckoutAttributes { get; set; }
        public virtual DbSet<CheckoutAttributeValue> CheckoutAttributeValues { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<CrossSellProduct> CrossSellProducts { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerAttribute> CustomerAttributes { get; set; }
        public virtual DbSet<CustomerAttributeValue> CustomerAttributeValues { get; set; }
        public virtual DbSet<CustomerRole> CustomerRoles { get; set; }
        public virtual DbSet<DeliveryDate> DeliveryDates { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<DiscountRequirement> DiscountRequirements { get; set; }
        public virtual DbSet<DiscountUsageHistory> DiscountUsageHistories { get; set; }
        public virtual DbSet<Download> Downloads { get; set; }
        public virtual DbSet<EmailAccount> EmailAccounts { get; set; }
        public virtual DbSet<ExternalAuthenticationRecord> ExternalAuthenticationRecords { get; set; }
        public virtual DbSet<Forums_Forum> Forums_Forum { get; set; }
        public virtual DbSet<Forums_Group> Forums_Group { get; set; }
        public virtual DbSet<Forums_Post> Forums_Post { get; set; }
        public virtual DbSet<Forums_PostVote> Forums_PostVote { get; set; }
        public virtual DbSet<Forums_PrivateMessage> Forums_PrivateMessage { get; set; }
        public virtual DbSet<Forums_Subscription> Forums_Subscription { get; set; }
        public virtual DbSet<Forums_Topic> Forums_Topic { get; set; }
        public virtual DbSet<GenericAttribute> GenericAttributes { get; set; }
        public virtual DbSet<GiftCard> GiftCards { get; set; }
        public virtual DbSet<GiftCardUsageHistory> GiftCardUsageHistories { get; set; }
        public virtual DbSet<GoogleProduct> GoogleProducts { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<LocaleStringResource> LocaleStringResources { get; set; }
        public virtual DbSet<LocalizedProperty> LocalizedProperties { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<ManufacturerTemplate> ManufacturerTemplates { get; set; }
        public virtual DbSet<MeasureDimension> MeasureDimensions { get; set; }
        public virtual DbSet<MeasureWeight> MeasureWeights { get; set; }
        public virtual DbSet<MessageTemplate> MessageTemplates { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsComment> NewsComments { get; set; }
        public virtual DbSet<NewsLetterSubscription> NewsLetterSubscriptions { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<OrderNote> OrderNotes { get; set; }
        public virtual DbSet<PermissionRecord> PermissionRecords { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<Poll> Polls { get; set; }
        public virtual DbSet<PollAnswer> PollAnswers { get; set; }
        public virtual DbSet<PollVotingRecord> PollVotingRecords { get; set; }
        public virtual DbSet<PredefinedProductAttributeValue> PredefinedProductAttributeValues { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Product_Category_Mapping> Product_Category_Mapping { get; set; }
        public virtual DbSet<Product_Manufacturer_Mapping> Product_Manufacturer_Mapping { get; set; }
        public virtual DbSet<Product_Picture_Mapping> Product_Picture_Mapping { get; set; }
        public virtual DbSet<Product_ProductAttribute_Mapping> Product_ProductAttribute_Mapping { get; set; }
        public virtual DbSet<Product_SpecificationAttribute_Mapping> Product_SpecificationAttribute_Mapping { get; set; }
        public virtual DbSet<ProductAttribute> ProductAttributes { get; set; }
        public virtual DbSet<ProductAttributeCombination> ProductAttributeCombinations { get; set; }
        public virtual DbSet<ProductAttributeValue> ProductAttributeValues { get; set; }
        public virtual DbSet<ProductReview> ProductReviews { get; set; }
        public virtual DbSet<ProductReviewHelpfulness> ProductReviewHelpfulnesses { get; set; }
        public virtual DbSet<ProductTag> ProductTags { get; set; }
        public virtual DbSet<ProductTemplate> ProductTemplates { get; set; }
        public virtual DbSet<ProductWarehouseInventory> ProductWarehouseInventories { get; set; }
        public virtual DbSet<QueuedEmail> QueuedEmails { get; set; }
        public virtual DbSet<RecurringPayment> RecurringPayments { get; set; }
        public virtual DbSet<RecurringPaymentHistory> RecurringPaymentHistories { get; set; }
        public virtual DbSet<RelatedProduct> RelatedProducts { get; set; }
        public virtual DbSet<ReturnRequest> ReturnRequests { get; set; }
        public virtual DbSet<ReturnRequestAction> ReturnRequestActions { get; set; }
        public virtual DbSet<ReturnRequestReason> ReturnRequestReasons { get; set; }
        public virtual DbSet<RewardPointsHistory> RewardPointsHistories { get; set; }
        public virtual DbSet<ScheduleTask> ScheduleTasks { get; set; }
        public virtual DbSet<SearchTerm> SearchTerms { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<Shipment> Shipments { get; set; }
        public virtual DbSet<ShipmentItem> ShipmentItems { get; set; }
        public virtual DbSet<ShippingByWeight> ShippingByWeights { get; set; }
        public virtual DbSet<ShippingMethod> ShippingMethods { get; set; }
        public virtual DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public virtual DbSet<SpecificationAttribute> SpecificationAttributes { get; set; }
        public virtual DbSet<SpecificationAttributeOption> SpecificationAttributeOptions { get; set; }
        public virtual DbSet<StateProvince> StateProvinces { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<StoreMapping> StoreMappings { get; set; }
        public virtual DbSet<StorePickupPoint> StorePickupPoints { get; set; }
        public virtual DbSet<TaxCategory> TaxCategories { get; set; }
        public virtual DbSet<TaxRate> TaxRates { get; set; }
        public virtual DbSet<TierPrice> TierPrices { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<TopicTemplate> TopicTemplates { get; set; }
        public virtual DbSet<UrlRecord> UrlRecords { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<VendorNote> VendorNotes { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .HasMany(e => e.Affiliates)
                .WithRequired(e => e.Address)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.Customers)
                .WithOptional(e => e.Address)
                .HasForeignKey(e => e.BillingAddress_Id);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.Customers1)
                .WithOptional(e => e.Address1)
                .HasForeignKey(e => e.ShippingAddress_Id);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Address)
                .HasForeignKey(e => e.BillingAddressId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.Orders1)
                .WithOptional(e => e.Address1)
                .HasForeignKey(e => e.PickupAddressId);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.Orders2)
                .WithOptional(e => e.Address2)
                .HasForeignKey(e => e.ShippingAddressId);

            modelBuilder.Entity<CheckoutAttributeValue>()
                .Property(e => e.PriceAdjustment)
                .HasPrecision(18, 4);

            modelBuilder.Entity<CheckoutAttributeValue>()
                .Property(e => e.WeightAdjustment)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Currency>()
                .Property(e => e.Rate)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Forums_Post)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Forums_Subscription)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Forums_Topic)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Logs)
                .WithOptional(e => e.Customer)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Forums_PrivateMessage)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.FromCustomerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Forums_PrivateMessage1)
                .WithRequired(e => e.Customer1)
                .HasForeignKey(e => e.ToCustomerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.CustomerRoles)
                .WithMany(e => e.Customers)
                .Map(m => m.ToTable("Customer_CustomerRole_Mapping"));

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Addresses)
                .WithMany(e => e.Customers2)
                .Map(m => m.ToTable("CustomerAddresses"));

            modelBuilder.Entity<CustomerRole>()
                .HasMany(e => e.TierPrices)
                .WithOptional(e => e.CustomerRole)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Discount>()
                .Property(e => e.DiscountPercentage)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Discount>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Discount>()
                .Property(e => e.MaximumDiscountAmount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Discount>()
                .HasMany(e => e.Categories)
                .WithMany(e => e.Discounts)
                .Map(m => m.ToTable("Discount_AppliedToCategories"));

            modelBuilder.Entity<Discount>()
                .HasMany(e => e.Manufacturers)
                .WithMany(e => e.Discounts)
                .Map(m => m.ToTable("Discount_AppliedToManufacturers"));

            modelBuilder.Entity<Discount>()
                .HasMany(e => e.Products)
                .WithMany(e => e.Discounts)
                .Map(m => m.ToTable("Discount_AppliedToProducts"));

            modelBuilder.Entity<Forums_Forum>()
                .HasMany(e => e.Forums_Topic)
                .WithRequired(e => e.Forums_Forum)
                .HasForeignKey(e => e.ForumId);

            modelBuilder.Entity<Forums_Group>()
                .HasMany(e => e.Forums_Forum)
                .WithRequired(e => e.Forums_Group)
                .HasForeignKey(e => e.ForumGroupId);

            modelBuilder.Entity<Forums_Post>()
                .HasMany(e => e.Forums_PostVote)
                .WithRequired(e => e.Forums_Post)
                .HasForeignKey(e => e.ForumPostId);

            modelBuilder.Entity<Forums_Topic>()
                .HasMany(e => e.Forums_Post)
                .WithRequired(e => e.Forums_Topic)
                .HasForeignKey(e => e.TopicId);

            modelBuilder.Entity<GiftCard>()
                .Property(e => e.Amount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<GiftCardUsageHistory>()
                .Property(e => e.UsedValue)
                .HasPrecision(18, 4);

            modelBuilder.Entity<MeasureDimension>()
                .Property(e => e.Ratio)
                .HasPrecision(18, 8);

            modelBuilder.Entity<MeasureWeight>()
                .Property(e => e.Ratio)
                .HasPrecision(18, 8);

            modelBuilder.Entity<News>()
                .HasMany(e => e.NewsComments)
                .WithRequired(e => e.News)
                .HasForeignKey(e => e.NewsItemId);

            modelBuilder.Entity<Order>()
                .Property(e => e.CurrencyRate)
                .HasPrecision(18, 8);

            modelBuilder.Entity<Order>()
                .Property(e => e.OrderSubtotalInclTax)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Order>()
                .Property(e => e.OrderSubtotalExclTax)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Order>()
                .Property(e => e.OrderSubTotalDiscountInclTax)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Order>()
                .Property(e => e.OrderSubTotalDiscountExclTax)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Order>()
                .Property(e => e.OrderShippingInclTax)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Order>()
                .Property(e => e.OrderShippingExclTax)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Order>()
                .Property(e => e.PaymentMethodAdditionalFeeInclTax)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Order>()
                .Property(e => e.PaymentMethodAdditionalFeeExclTax)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Order>()
                .Property(e => e.OrderTax)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Order>()
                .Property(e => e.OrderDiscount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Order>()
                .Property(e => e.OrderTotal)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Order>()
                .Property(e => e.RefundedAmount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.GiftCardUsageHistories)
                .WithRequired(e => e.Order)
                .HasForeignKey(e => e.UsedWithOrderId);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.RecurringPayments)
                .WithRequired(e => e.Order)
                .HasForeignKey(e => e.InitialOrderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.RewardPointsHistories)
                .WithOptional(e => e.Order)
                .HasForeignKey(e => e.UsedWithOrder_Id);

            modelBuilder.Entity<OrderItem>()
                .Property(e => e.UnitPriceInclTax)
                .HasPrecision(18, 4);

            modelBuilder.Entity<OrderItem>()
                .Property(e => e.UnitPriceExclTax)
                .HasPrecision(18, 4);

            modelBuilder.Entity<OrderItem>()
                .Property(e => e.PriceInclTax)
                .HasPrecision(18, 4);

            modelBuilder.Entity<OrderItem>()
                .Property(e => e.PriceExclTax)
                .HasPrecision(18, 4);

            modelBuilder.Entity<OrderItem>()
                .Property(e => e.DiscountAmountInclTax)
                .HasPrecision(18, 4);

            modelBuilder.Entity<OrderItem>()
                .Property(e => e.DiscountAmountExclTax)
                .HasPrecision(18, 4);

            modelBuilder.Entity<OrderItem>()
                .Property(e => e.OriginalProductCost)
                .HasPrecision(18, 4);

            modelBuilder.Entity<OrderItem>()
                .Property(e => e.ItemWeight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<OrderItem>()
                .HasMany(e => e.GiftCards)
                .WithOptional(e => e.OrderItem)
                .HasForeignKey(e => e.PurchasedWithOrderItemId);

            modelBuilder.Entity<PermissionRecord>()
                .HasMany(e => e.CustomerRoles)
                .WithMany(e => e.PermissionRecords)
                .Map(m => m.ToTable("PermissionRecord_Role_Mapping"));

            modelBuilder.Entity<PredefinedProductAttributeValue>()
                .Property(e => e.PriceAdjustment)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PredefinedProductAttributeValue>()
                .Property(e => e.WeightAdjustment)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PredefinedProductAttributeValue>()
                .Property(e => e.Cost)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.AdditionalShippingCharge)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.OldPrice)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductCost)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.SpecialPrice)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.MinimumCustomerEnteredPrice)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.MaximumCustomerEnteredPrice)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.BasepriceAmount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.BasepriceBaseAmount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.Weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.Length)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.Width)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.Height)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductTags)
                .WithMany(e => e.Products)
                .Map(m => m.ToTable("Product_ProductTag_Mapping"));

            modelBuilder.Entity<Product_ProductAttribute_Mapping>()
                .HasMany(e => e.ProductAttributeValues)
                .WithRequired(e => e.Product_ProductAttribute_Mapping)
                .HasForeignKey(e => e.ProductAttributeMappingId);

            modelBuilder.Entity<ProductAttributeCombination>()
                .Property(e => e.OverriddenPrice)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ProductAttributeValue>()
                .Property(e => e.PriceAdjustment)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ProductAttributeValue>()
                .Property(e => e.WeightAdjustment)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ProductAttributeValue>()
                .Property(e => e.Cost)
                .HasPrecision(18, 4);

            modelBuilder.Entity<RewardPointsHistory>()
                .Property(e => e.UsedAmount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Shipment>()
                .Property(e => e.TotalWeight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ShippingMethod>()
                .HasMany(e => e.Countries)
                .WithMany(e => e.ShippingMethods)
                .Map(m => m.ToTable("ShippingMethodRestrictions"));

            modelBuilder.Entity<ShoppingCartItem>()
                .Property(e => e.CustomerEnteredPrice)
                .HasPrecision(18, 4);

            modelBuilder.Entity<StorePickupPoint>()
                .Property(e => e.PickupFee)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TaxRate>()
                .Property(e => e.Percentage)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TierPrice>()
                .Property(e => e.Price)
                .HasPrecision(18, 4);
        }
    }
}
