namespace MyBinary.Queries
{
    public class HealthcheckRequest
    {
        public int Interval { get; set; }
        public string Url { get; set; }
    }
}