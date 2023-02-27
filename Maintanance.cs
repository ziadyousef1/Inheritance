namespace inheritance
{
    public class Maintanance : Empyoyee
    {
        private const decimal hardShip = 100m;
        public Maintanance(int id, string name, decimal loggedHours, decimal wage) : base(id, name, loggedHours, wage) { }

        public override decimal calculate()
        {
            return base.calculate() + hardShip;
        }
      
        public override string ToString()
        {
            return base.ToString() +
            $"\nHardShip: ${Math.Round(hardShip, 2):N0}" +
                $"\nNetsalary:${Math.Round(this.calculate(), 2):N0}";
        }
    }
}