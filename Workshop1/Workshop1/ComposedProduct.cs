namespace Workshop1
{
    public class ComposedProduct : Products
    {
        public List<Products> Products { get; set; }


        public float Discount { get; set; }

        public override string ToString()
        {
            string product = " ";
            foreach (Products Products in Products)
            {
                product += Products.Description + ", ";
            }
            return $"\n{Id} - {Description}" +
                $"\n Products: {product}" +
                $"\n Discount: {Discount:P2}" +
                $"\n Value to pay is: {ValueToPay():C2}";
        }

        public override decimal ValueToPay()
        {
            decimal payroll = 0;
            foreach (Products Products in Products)
            {
                payroll += Products.ValueToPay();
            }
            return payroll - (payroll * (decimal)Discount);

        }

    }
}
