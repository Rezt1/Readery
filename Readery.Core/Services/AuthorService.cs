using Microsoft.AspNetCore.Identity;
using Readery.Core.Contracts;
using Readery.Core.Models.Author;
using Readery.Domain.Data.Common;
using Readery.Domain.Data.Models;
using System.Globalization;

namespace Readery.Core.Services
{
	public class AuthorService : IAuthorService
    {
        private readonly IRepository repository;
        private readonly UserManager<ApplicationUser> userManager;

        public AuthorService(IRepository _repository, UserManager<ApplicationUser> _userManager)
        {
            repository = _repository;
            userManager = _userManager;
        }

        public async Task CreateAuthorAsync(BecomeAuthorViewModel model, string userId)
        {
            var user = await repository.GetByIdAsync<ApplicationUser>(Guid.Parse(userId));
            user!.PhoneNumber = model.PhoneNumber;

            var country = await repository.GetByIdAsync<Country>(model.Address.CountryId);

            var address = new Address()
            {
                Street = model.Address.Street,
                City = model.Address.City,
                Country = country!
            };
			await repository.AddAsync(address);
			await repository.SaveChangesAsync();

			var author = new Author()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                BirthDate = DateTime.ParseExact(model.BirthDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None),
                UserId = user.Id,
                AddressId = address.Id,
            };

			address.Author = author;
            user.Author = author;

			await repository.AddAsync(author);

			await userManager.AddToRoleAsync(user, "Author");

			await repository.SaveChangesAsync();
		}
    }
}
