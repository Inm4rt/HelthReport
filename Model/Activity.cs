namespace HelthReport.Model
{
    public class Activity
    {
        public bool BentOverWork { get; set; }
        public DateTime DateTime { get; set; }
        public string? Kind {  get; set; }
        public int CountSteps { get; set; }
    }
}
