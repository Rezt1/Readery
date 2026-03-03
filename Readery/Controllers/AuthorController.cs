using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Readery.Core.Contracts;
using Readery.Core.Models.Author;
using Readery.Domain.Data.Common;
using Readery.Domain.Data.Models;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Readery.Core.Models.Book;

namespace Readery.Controllers
{
    [Authorize]
    public class AuthorController : Controller
    {
        private readonly ICountryService countryService;
        private readonly IAuthorService authorService;
        private readonly IPublisherService publisherService;
        private readonly SignInManager<ApplicationUser> signInManager;
		private readonly UserManager<ApplicationUser> userManager;

		public AuthorController(
            ICountryService _countryService, 
            IAuthorService _authorService,
            IPublisherService _publisherService,
            SignInManager<ApplicationUser> _signInManager, 
            UserManager<ApplicationUser> _userManager)
		{
			countryService = _countryService;
			authorService = _authorService;
            publisherService = _publisherService;
			signInManager = _signInManager;
			userManager = _userManager;
		}

		[HttpGet]
        public async Task<IActionResult> Become()
        {
			var roles = User.Claims
					.Where(c => c.Type == ClaimTypes.Role)
					.Select(c => c.Value)
					.ToList();
            
			if (User.IsInRole("Author"))
            {
                return RedirectToAction("Index", "Home");
            }

            var model = new BecomeAuthorViewModel();

            model.Address.Countries = await countryService.GetCountriesAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Become(BecomeAuthorViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Address.Countries = await countryService.GetCountriesAsync();
                return View(model);
            }

            if (User.IsInRole("Author"))
            {
                return RedirectToAction("Index", "Home");
            }

            await authorService.CreateAuthorAsync(model, User.Id());

            await signInManager.SignOutAsync();
            await signInManager.SignInAsync(await userManager.FindByIdAsync(User.Id()), false);

			return RedirectToAction("Index", "Home");
        }

        [Authorize(Roles = "Author")]
        [HttpGet]
        public async Task<IActionResult> AddBook()
        {
            var model = new AddBookViewModel();

            model.Publisher.Address.Countries = await countryService.GetCountriesAsync();
            model.Publishers = await publisherService.GetPublishersAsync();

            return View(model);
        }

        [Authorize(Roles = "Author")]
        [HttpPost]
        public async Task<IActionResult> AddBook(AddBookViewModel model)
        {
            if (!ModelState.IsValid)
            {
				model.Publisher.Address.Countries = await countryService.GetCountriesAsync();
				model.Publishers = await publisherService.GetPublishersAsync();
				return View(model);
            }

            return View(model);
        }
    }
}
