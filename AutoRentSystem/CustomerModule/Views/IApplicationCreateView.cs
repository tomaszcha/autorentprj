using CustomerModule.ViewModels;
using ModulesInfrastructure.Views;

namespace CustomerModule.Views
{
    public interface IApplicationCreateView : IView
    {
        IApplicationCreateViewModel applicationCreateViewModel { get; set; }
    }
}
