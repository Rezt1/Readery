using Microsoft.AspNetCore.Identity;
using Readery.Domain.Data.Models;

namespace Readery.Domain.Data.Configuration
{
    internal class DataSeeder
    {
        internal ApplicationUser CommonUser { get; set; } = null!;

        internal ApplicationUser AuthorUser { get; set; } = null!;

        internal Country Country1 { get; set; } = null!;

        internal Country Country2 { get; set; } = null!;

        internal Country Country3 { get; set; } = null!;

        internal Country Country4 { get; set; } = null!;

        internal Address AuthorAddress { get; set; } = null!;

        internal Address PublisherAddress { get; set; } = null!;

        internal Author Author { get; set; } = null!;

        internal Publisher Publisher { get; set; } = null!;

        internal Book Book1 { get; set; } = null!;

        internal Book Book2 { get; set; } = null!;

        internal Book Book3 { get; set; } = null!;

        internal Book Book4 { get; set; } = null!;

        public DataSeeder()
        {
            SeedApplicationUsers();
            SeedCountries();
            SeedAddresses();
            SeedAuthor();
            SeedPublisher();
            SeedBooks();
        }

        private void SeedApplicationUsers()
        {
            CommonUser = new ApplicationUser()
            {
                Id = Guid.NewGuid(),
                UserName = "Common",
                NormalizedUserName = "COMMON",
                Email = "common1@gmail.com",
                NormalizedEmail = "COMMON1@GMAIL.COM",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
            };

            AuthorUser = new ApplicationUser()
            {
                Id = new Guid("c18fa7b4-63a5-4cb2-a07c-99eaf9134fd1"),
                UserName = "Author",
                NormalizedUserName = "AUTHOR",
                Email = "author1@gmail.com",
                NormalizedEmail = "AUTHOR@GMAIL.COM",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
            };

            var passwordHasher = new PasswordHasher<ApplicationUser>();

            CommonUser.PasswordHash = passwordHasher.HashPassword(CommonUser, "commonPassword");
            AuthorUser.PasswordHash = passwordHasher.HashPassword(AuthorUser, "commonPassword");
        }

        private void SeedCountries()
        {
            Country1 = new Country()
            {
                Id = 1,
                Name = "Germany"
            };

            Country2 = new Country()
            {
                Id = 2,
                Name = "Bulgaria"
            };

            Country3 = new Country()
            {
                Id = 3,
                Name = "France"
            };

            Country4 = new Country()
            {
                Id = 4,
                Name = "Japan"
            };
        }

        private void SeedAddresses()
        {
            AuthorAddress = new Address()
            {
                Id = 1,
                Street = "Dragon Path 5",
                City = "Tokyo",
                CountryId = Country4.Id,
            };

            PublisherAddress = new Address()
            {
                Id = 2,
                Street = "Snake Street 18",
                City = "Tokyo",
                CountryId = Country4.Id,
            };
        }

        private void SeedAuthor()
        {
            Author = new Author()
            {
                Id = 1,
                FirstName = "Syougo",
                LastName = "Kinugasa",
                BirthDate = new DateTime(1990, 9, 25),
                AddressId = AuthorAddress.Id,
                UserId = AuthorUser.Id
            };

            AuthorUser.AuthorId = Author.Id;
            AuthorAddress.AuthorId = Author.Id;
        }

        private void SeedPublisher()
        {
            Publisher = new Publisher()
            {
                Id = 1,
                Name = "Seven Seas",
                Email = "publisher@gmail.com",
                PhoneNumber = "+81 1234 5678",
                AddressId = PublisherAddress.Id,
            };

            PublisherAddress.PublisherId = Publisher.Id;
        }

        private void SeedBooks()
        {
            Book1 = new Book()
            {
                Id = 1,
                Title = "Classroom of the elite (Light Novel) Vol. 1",
                Description = "The main character does some pretty amazing stuff and is super amazing",
                ImagePath = "images/books/cote1.jpg",
                Language  = "en",
                PagesCount = 301,
                Price = 30.00m,
                IsRemoved = false,
                WrittenOn = new DateTime(2020, 10, 10),
                AddedOn = DateTime.Now,
                AuthorId = Author.Id,
                PublisherId = Publisher.Id,
            };

            Book2 = new Book()
            {
                Id = 2,
                Title = "Classroom of the elite (Light Novel) Vol. 3",
                Description = "The main character does some pretty bad stuff and is super evil",
                ImagePath = "images/books/cote3.jpg",
                Language = "en",
                PagesCount = 280,
                Price = 27.00m,
                IsRemoved = false,
                WrittenOn = new DateTime(2017, 5, 10),
                AddedOn = DateTime.Now,
                AuthorId = Author.Id,
                PublisherId = Publisher.Id,
            };

            Book3 = new Book()
            {
                Id = 3,
                Title = "Classroom of the elite (Light Novel) Vol. 6",
                Description = "The main character does some pretty shady stuff and is super sneaky",
                ImagePath = "images/books/cote6.jpg",
                Language = "en",
                PagesCount = 445,
                Price = 35.00m,
                IsRemoved = false,
                WrittenOn = new DateTime(2008, 6, 16),
                AddedOn = DateTime.Now,
                AuthorId = Author.Id,
                PublisherId = Publisher.Id,
            };

            Book4 = new Book()
            {
                Id = 4,
                Title = "Classroom of the elite (Light Novel) Vol. 8",
                Description = "The main character does some pretty embarassing stuff and is super unbothered",
                ImagePath = "images/books/cote8.jpg",
                Language = "en",
                PagesCount = 415,
                Price = 35.50m,
                IsRemoved = false,
                WrittenOn = new DateTime(2008, 6, 16),
                AddedOn = DateTime.Now,
                AuthorId = Author.Id,
                PublisherId = Publisher.Id,
            };
        }
    }
}
