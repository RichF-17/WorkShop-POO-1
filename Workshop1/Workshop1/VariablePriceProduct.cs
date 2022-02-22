namespace Workshop1
{
    public class VariablePriceProduct : Products
    {
        public string Measurement { get; set; }
        public float Quantity { get; set; }
        public override string ToString()
        {
            return base.ToString() + $" Mesurement:....... {Measurement}" +
                                     $"\n Quantity is:...... {Quantity:F2}" +
                                     $"\n Value to pay is: ..... {ValueToPay():C2}";

        }

        public override decimal ValueToPay()
        {
            return (decimal)Price * (decimal)Quantity + (decimal)Tax * ((decimal)Price * (decimal)Quantity);
        }
    }
}
