namespace Workshop1
{
    public class FixedPriceProduct : Products
    {
        public override string ToString()
        {
            return base.ToString() + $" Value to pay is: {ValueToPay():C2}";
        }
        public override decimal ValueToPay()
        {

            return (Price * (decimal)Tax) + Price;
        }
    }
}
