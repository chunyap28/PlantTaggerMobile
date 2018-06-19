using System.Threading.Tasks;

namespace Plant_Tagger.Services
{
    public interface IDialogService
    {
        Task ShowAlertAsync(string message, string title, string buttonLabel);
    }
}
