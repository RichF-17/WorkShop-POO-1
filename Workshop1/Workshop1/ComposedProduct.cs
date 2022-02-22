namespace Workshop1
{
    public class ComposedProduct : Products
    {
        public List<Products> Products { get; set; }


        public float Discount { get; set; }

        public override string ToString()
        {
            List<string> product = new List<string>();

            foreach (Products Products in Products)
            {
                string.Join("\n", product);
            }
            //string product = " ";
            //foreach (Products Products in Products)
            //{
            //  product += Products.Description + ", ";
            //}
            return $"\n{Id} - {Description}" +
                $"\n\t Products:.........: {product}" +
                $"\n\t Discount:.........: {$"{Discount:P2}",18}" +
                $"\n\t Value to pay is:..: {$"{ValueToPay():C2}",18}"; 
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
