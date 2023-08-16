using System.Text.Json;

namespace ExceptionFilterDemo.Models
{
    public class ExceptionModel
    {
        public string Status { get; set; }
        public string Message { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
