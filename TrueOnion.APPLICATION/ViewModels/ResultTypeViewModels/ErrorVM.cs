
namespace TrueOnion.APPLICATION.ViewModels.ResultTypeViewModels
{
    public class ErrorVM
    {
        public ErrorVM()
        {
            Errors = new List<string>();
        }
        public List<string> Errors { get; set; }
        public int StatusCode { get; set; }
    }
}
