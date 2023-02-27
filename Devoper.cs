namespace inheritance
{
    public class Devoper : Empyoyee
    {
        public const decimal  commission = 0.03m;
        public bool Taskcompleted { get; set; }
        public Devoper(int id, string name, decimal loggedHours, decimal wage, bool Taskcompleted) : base(id, name, loggedHours, wage)
        {
            this.Taskcompleted = Taskcompleted;
        }



        public override decimal calculate()
        {
            return base.calculate() + calculateBonus();
        }
        private decimal calculateBonus()
        {
            if (Taskcompleted)
            {
                return base.calculate() * commission;
            }
            return 0;
        }
        public override string ToString()
        {
            return base.ToString() +
            $"\nTaskcompleted: ${(Taskcompleted ? "True":"False" )} " +
            $"\nBonus: ${Math.Round(calculateBonus(), 2):N0}" +
                $"\nNetsalary:${Math.Round(calculate(), 2):N0}";
        }
    }
}