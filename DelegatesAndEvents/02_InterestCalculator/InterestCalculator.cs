namespace _02_InterestCalculator
{
    public delegate decimal CalculateInterest(decimal sum, decimal rate, int years);

    public class InterestCalculator
    {
        private decimal rate;

        public InterestCalculator(decimal sum, decimal rate, int years, CalculateInterest del)
        {
            this.Sum = sum;
            this.Rate = rate;
            this.Years = years;
            this.Del = del;
        }

        public decimal Sum { get; set; }

        public decimal Rate
        {
            get { return this.rate; }
            set
            {
                this.rate = value;
            }
        }

        public int Years { get; set; }

        public CalculateInterest Del { get; set; }

        public override string ToString()
        {
            return this.Del(this.Sum, this.Rate, this.Years).ToString("F4");
        }
    }
}
