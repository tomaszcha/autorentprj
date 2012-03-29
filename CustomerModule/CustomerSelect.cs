using Microsoft.Practices.Prism.Events;
using ModuleInfrastracture.ViewModels;
using CustomerModule.ViewModels;
namespace CustomerModule.Events
{    
   public class CustomerSelect : CompositePresentationEvent<CustomerViewModel>
   {
   }
}
