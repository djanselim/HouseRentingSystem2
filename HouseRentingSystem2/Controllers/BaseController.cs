using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem2.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        
    }
}
