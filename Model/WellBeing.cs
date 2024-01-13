namespace HelthReport.Model
{
    public class WellBeing
    {
        public int UpperPressure { get; set; }
        public int LowerPressure { get; set;}
        public int BodyTemperature { get; set;}
        public DateTime DateTime { get; set;}
        public double AmountOxygenBlood { get; set;}
        public int pulse { get; set;}

    }
}
