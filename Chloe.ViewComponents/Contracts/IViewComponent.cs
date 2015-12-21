using System.Threading.Tasks;

namespace Chloe.ViewComponents.Contracts
{
    public interface IViewComponent
    {
        Task InvokeAsync();
        ViewComponentType ViewComponentType { get; set; }
    }
}
