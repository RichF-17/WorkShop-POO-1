namespace Workshop1
{
    public class FixedPriceProduct : Products
    {
        public override string ToString()
        {
            return base.ToString() + $"\n\t Value to pay is...: {$"{ValueToPay():C2}",18}";
        }
        public override decimal ValueToPay()
        {

            return (Price * (decimal)Tax) + Price;
        }
    }
}
