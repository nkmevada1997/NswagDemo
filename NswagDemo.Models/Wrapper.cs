namespace NswagDemo.Models
{
    public class Wrapper
    {
        public bool IsError { get; set; }

        public string Message { get; set; } = null!;

        public string ExceptionMessage { get; set; } = null!;
    }
}
