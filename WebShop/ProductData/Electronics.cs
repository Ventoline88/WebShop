namespace WebShop.ProductData
{
    public class Electronics : Product
    {
        public int WarrantyYears;

        public override string ProductInformation()
        {
            return $"Product {Name} of brand {Brand} costs {Price}. Warranty is {WarrantyYears}";
        }
    }
}