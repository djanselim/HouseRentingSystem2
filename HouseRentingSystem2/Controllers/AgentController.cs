using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Models.Agent;
using HouseRentingSystem2.Attributes;
using HouseRentingSystem2.Extensions;
using Microsoft.AspNetCore.Mvc;
using static HouseRentingSystem.Core.Constants.MessageConstants;

namespace HouseRentingSystem2.Controllers
{
    public class AgentController : BaseController
	{
		private readonly IAgentService agentService;

        public AgentController(IAgentService _agentService)
        {
			agentService = _agentService;			    
        }

        [HttpGet]
		[NotAnAgent]
		public IActionResult Become()
		{
			var model = new BecomeAgentFormModel();

			return View(model);
		}

		[HttpPost]
		[NotAnAgent]
		public async Task<IActionResult> Become(BecomeAgentFormModel model)
		{
			if(await agentService.UserWithPhoneNumberExistsAsync(User.Id()))
			{
				ModelState.AddModelError(nameof(model.PhoneNumber), PhoneExists);
			}

			if(await agentService.UserHasRentsAsync(User.Id()))
			{
				ModelState.AddModelError("Error", HasRents); 
			}

			if(ModelState.IsValid == false)
			{
				return View(model);
			}

			await agentService.CreatAsync(User.Id(), model.PhoneNumber); 

			return RedirectToAction(nameof(HouseController.All), "House");
		}
	}
}
