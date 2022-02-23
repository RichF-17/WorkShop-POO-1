namespace Workshop1
{
    public class VariablePriceProduct : Products
    {
        public string Measurement { get; set; }
        public float Quantity { get; set; }
        public override string ToString()
        {
            return base.ToString() + $"\n\t Mesurement:.......: {$"{Measurement}",18}" +
                                     $"\n\t Quantity is:......: {$"{Quantity:F2}",18}" +
                                     $"\n\t Price to value:...: {$"{ValueToPay():C2}",18}";
                                     

        }

        public override decimal ValueToPay()
        {
            return (decimal)Price * (decimal)Quantity + (decimal)Tax * ((decimal)Price * (decimal)Quantity);
        }
    }
}
