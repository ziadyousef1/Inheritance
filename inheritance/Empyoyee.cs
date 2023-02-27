namespace inheritance
{
    public class Empyoyee

    {
        private const int MinimamLoggedhours = 176;
        private const decimal OverTimerate = 1.25m;

        public Empyoyee(int id, string name, decimal loggedHours, decimal wage)
        {
            Id = id;
            Name = name;
            LoggedHours = loggedHours;
            Wage = wage;
        }

        protected int Id { get; set; }
        protected string Name { get; set; }
        protected decimal LoggedHours { get; set; }
        protected decimal Wage { get; set; }
        public virtual decimal calculate()
        {
            return  calculateBasesalary()+ calculateOvertime();
        }
        private decimal calculateBasesalary()
        {
            return LoggedHours * Wage;
        }
         private decimal calculateOvertime()
        {
            var additionalHours = ((LoggedHours - MinimamLoggedhours) > 0 ? this.LoggedHours - MinimamLoggedhours : 0);
            return additionalHours* Wage* OverTimerate;
        }
        public override string ToString()
        {
            var type = GetType().ToString().Replace("inheritance.","");
            return $"{type}\n"+$"\nId:{Id}" + $"\nName:{Name}" + $"\nLoggedhours:{LoggedHours}" +$"\nWage:{Wage}"
                + $"\nBasesalary:{Math.Round(calculateBasesalary(),2):N0}" + $"\nOvertime: {Math.Round(calculateOvertime(),2):N0}";
        }
    }
}