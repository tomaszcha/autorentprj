using ApplicationCreate.ViewModels;
using ModulesInfrastructure.Views;

namespace ApplicationCreate.Views
{
    public interface IApplicationCreateView : IView
    {
        IApplicationCreateViewModel applicationCreateViewModel { get; set; }
    }
}
