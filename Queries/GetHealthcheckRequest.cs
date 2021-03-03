namespace MyBinary.Queries
{
    public class GetHealthcheckRequest
    {
        public int Interval { get; set; }
        public string Url { get; set; }
    }
}