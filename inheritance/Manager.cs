namespace inheritance
{
    public class Manager : Empyoyee
    {
        private const decimal AllowanceRate = 0.05m;
        public Manager(int id, string name, decimal loggedHours, decimal wage) : base(id, name, loggedHours, wage) { }

        protected bool Taskcompleted { get; set; }

        public override decimal calculate()
        {
            return base.calculate() + calculateAllwance();
        }
        private decimal calculateAllwance()
        {
            
            return base.calculate()*AllowanceRate;
        }
        public override string ToString()
        {
            return base.ToString() +
            $"\nAllowanceRate: ${AllowanceRate} " +
            
                $"\nNetsalary:${Math.Round(calculate(), 2):N0}";
        }
    }
}