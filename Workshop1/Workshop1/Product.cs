namespace Workshop1
{
    public abstract class Products : IPay
    {
        public string Description { get; set; }
        public int Id { get; set; }
        public decimal Price { get; set; }
        public float Tax { get; set; }

        public abstract decimal ValueToPay();

        public override string ToString()
        {
            return $"\n{Id} - {Description}" +
                $"\n Price to value:... {Price:C2}" +
                $"\n Tax is:........... {Tax:P2}\n";
        }
    }
}
