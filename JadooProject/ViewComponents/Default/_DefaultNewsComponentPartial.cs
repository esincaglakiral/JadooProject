using Microsoft.AspNetCore.Mvc;

namespace JadooProject.ViewComponents.Default
{
    public class _DefaultNewsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
