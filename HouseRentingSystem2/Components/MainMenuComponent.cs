﻿using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem2.Components
{
	public class MainMenuComponent : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			return await Task.FromResult<IViewComponentResult>(View());
		}
	}
}
