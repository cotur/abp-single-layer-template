using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace MyCompanyName.MyProjectName.Controllers.Home;

[Route("/")]
public class HomeController : AbpController
{
    public IActionResult Index()
    {
        return new RedirectResult("/todo");
    }
}