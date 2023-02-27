namespace inheritance
{
    public class Sales : Empyoyee
    {
       protected decimal SalesVolume { get; set; }
       protected decimal Commission { get; set; }
        public Sales(int id, string name, decimal loggedHours, decimal wage,decimal salesvolume, decimal commission) : base(id, name, loggedHours, wage)
        {
            this.SalesVolume = salesvolume;
            this.Commission = commission;
        }

        public override decimal calculate()
        {
            return base.calculate() + calculateBonus();
        }
        private decimal calculateBonus()
        {
            return Commission * SalesVolume;
        }
        public override string ToString()
        {
            return base.ToString() +
            $"\nCommission: ${Math.Round(Commission, 2):N0}" +
            $"\nBonus: ${Math.Round(calculateBonus(), 2):N0}" +
                $"\nNetsalary:${Math.Round(calculate(), 2):N0}";
        }
    }

}