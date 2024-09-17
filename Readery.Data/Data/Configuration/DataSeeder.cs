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

		internal Book Book5 { get; set; } = null!;

		internal Book Book6 { get; set; } = null!;

		internal Book Book7 { get; set; } = null!;

		internal Book Book8 { get; set; } = null!;

		internal Book Book9 { get; set; } = null!;

		internal Book Book10 { get; set; } = null!;

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
                RememberDeliveryInfo = false
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
                RememberDeliveryInfo = false
            };

            var passwordHasher = new PasswordHasher<ApplicationUser>();

            CommonUser.PasswordHash = passwordHasher.HashPassword(CommonUser, "commonPassword");
            AuthorUser.PasswordHash = passwordHasher.HashPassword(AuthorUser, "authorPassword");
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
                Description = "Students of the prestigious Tokyo Metropolitan Advanced Nurturing High School are given remarkable freedom—if they can win, barter, or save enough points to work their way up the ranks! Ayanokouji Kiyotaka has landed at the bottom in the scorned Class D, where he meets Horikita Suzune, who’s determined to rise up the ladder to Class A. Can they beat the system in a school where cutthroat competition is the name of the game?",
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
                Description = "Having survived their final exams, Ayanokouji and the others are looking forward to an idyllic school-sponsored summer vacation aboard a cruise ship. But nothing is ever quite as it seems with the Tokyo Advanced Nurturing High School, and the cruise turns out to be the cover for a series of special tests! What grueling new challenges await them out at sea?!",
                ImagePath = "images/books/cote3.jpg",
                Language = "en",
                PagesCount = 280,
                Price = 27.00m,
                IsRemoved = false,
                WrittenOn = new DateTime(2021, 4, 15),
                AddedOn = DateTime.Now,
                AuthorId = Author.Id,
                PublisherId = Publisher.Id,
            };

            Book3 = new Book()
            {
                Id = 3,
                Title = "Classroom of the elite (Light Novel) Vol. 6",
                Description = "There’s upheaval in the air as another special exam approaches and Nagumo officially replaces Horikita Manabu as student council president. Meanwhile, Ryuuen is out for blood, and he’s set his sights on Horikita Suzune as the next possible candidate for Class D’s mysterious mastermind!",
                ImagePath = "images/books/cote6.jpg",
                Language = "en",
                PagesCount = 445,
                Price = 35.00m,
                IsRemoved = false,
                WrittenOn = new DateTime(2021, 8, 17),
                AddedOn = DateTime.Now,
                AuthorId = Author.Id,
                PublisherId = Publisher.Id,
            };

            Book4 = new Book()
            {
                Id = 4,
                Title = "Classroom of the elite (Light Novel) Vol. 8",
                Description = "The third semester kicks off in high gear with a special boot camp deep in the mountains. Forcibly separated into groups along grade and gender lines, the first, second and third years alike must work together to survive the rugged terrain. Even worse? The leader of the group that comes in last will be expelled. Can Class D make it back to campus intact, or is this where they finally say goodbye to one of their own?",
                ImagePath = "images/books/cote8.jpg",
                Language = "en",
                PagesCount = 415,
                Price = 35.50m,
                IsRemoved = false,
                WrittenOn = new DateTime(2021, 12, 14),
                AddedOn = DateTime.Now,
                AuthorId = Author.Id,
                PublisherId = Publisher.Id,
            };

            Book5 = new Book()
            {
                Id = 5,
                Title = "Classroom of the elite: Year 2 (Light Novel) Vol. 2",
                Description = "Ayanokouji’s relationship with Karuizawa deepens, while the aftershock of his perfect mathematics score ripples through the school. Horikita asks to join the student council, and is accepted by Nagumo. And summer vacation brings with it no rest, but another special exam–a reprise of the earlier deserted island test. Except this time, it’ll be a battle royale with all three grade levels duking it out against each other!",
				ImagePath = "images/books/cote-y2-2.jpg",
				Language = "en",
				PagesCount = 330,
				Price = 33.50m,
				IsRemoved = false,
				WrittenOn = new DateTime(2023, 5, 16),
				AddedOn = DateTime.Now,
				AuthorId = Author.Id,
				PublisherId = Publisher.Id,
			};

			Book6 = new Book()
			{
				Id = 6,
				Title = "Classroom of the elite: Year 2 (Light Novel) Vol. 3",
				Description = "The special exam on an uninhabited island has begun! For two weeks, students will do their best to visit checkpoints and complete challenges to gain points with their groups. Well, except for Ayanokouji, who has opted to tackle this exam on his own… or has he? Nanase, a first-year student from Class D, breaks off from her own group and asks to tag along with him, but there doesn’t seem to be anything in it for her. Just what is this under-classman’s goal?",
				ImagePath = "images/books/cote-y2-3.jpg",
				Language = "en",
				PagesCount = 338,
				Price = 35.10m,
				IsRemoved = false,
				WrittenOn = new DateTime(2023, 7, 15),
				AddedOn = DateTime.Now,
				AuthorId = Author.Id,
				PublisherId = Publisher.Id,
			};

			Book7 = new Book()
			{
				Id = 7,
				Title = "Classroom of the elite (Light Novel) Vol. 2",
				Description = "Class D has conquered the midterms, but their celebration is cut short when three Class C students falsely accuse Sudou of assaulting them! With their friend facing expulsion, and the class’s points on the line, Ayanokouji, Horikita, and Kikyou must team up to gather evidence to prove his innocence.",
				ImagePath = "images/books/cote2.jpg",
				Language = "en",
				PagesCount = 352,
				Price = 37.20m,
				IsRemoved = false,
				WrittenOn = new DateTime(2021, 1, 10),
				AddedOn = DateTime.Now,
				AuthorId = Author.Id,
				PublisherId = Publisher.Id,
			};

			Book8 = new Book()
			{
				Id = 8,
				Title = "Classroom of the elite (Light Novel) Vol. 7.5",
				Description = "School may be on vacation, but the scheming never stops! Christmas draws near, and Karuizawa and Satou compete for Ayanokouji’s affections while new student council president Nagumo makes his first sinister moves. Don’t miss this bonus volume of short stories, covering the events of a winter break that will decide the balance of power in the upcoming third semester!",
				ImagePath = "images/books/cote7-5.jpg",
				Language = "en",
				PagesCount = 352,
				Price = 32.60m,
				IsRemoved = false,
				WrittenOn = new DateTime(2021, 10, 21),
				AddedOn = DateTime.Now,
				AuthorId = Author.Id,
				PublisherId = Publisher.Id,
			};

			Book9 = new Book()
			{
				Id = 9,
				Title = "Classroom of the elite (Light Novel) Vol. 9",
				Description = "Sakayanagi puts her plan to crush Ichinose into motion, spreading rumors of her alleged war criminal history through the school like wildfire. With Class B at a loss, and Ichinose herself uncharacteristically reluctant to fight back, can Ayanokouji step in to save her reputation? Meanwhile, Kushida makes contact with student council president Nagumo in what might prove to be a very dangerous alliance, indeed.",
				ImagePath = "images/books/cote9.jpg",
				Language = "en",
				PagesCount = 342,
				Price = 33.20m,
				IsRemoved = false,
				WrittenOn = new DateTime(2022, 4, 29),
				AddedOn = DateTime.Now,
				AuthorId = Author.Id,
				PublisherId = Publisher.Id,
			};

			Book10 = new Book()
			{
				Id = 10,
				Title = "Classroom of the elite (Light Novel) Vol. 10",
				Description = "It's spring, and for the first time in the school’s history, no one has been expelled after the third semester exams. As a result, the Advanced Nurturing High School sets a cruel test—each class must choose one of their own members to be expelled. Chaos consumes the first-years as Hirata tries and fails to keep the class from turning on each other, Ichinose strikes a costly bargain with Nagumo, and Ryuuen’s classmates seem ready to throw him to the wolves. Can Class C make it out of this unscathed—or will they be undone by traitors within?",
				ImagePath = "images/books/cote10.jpg",
				Language = "en",
				PagesCount = 383,
				Price = 39.20m,
				IsRemoved = false,
				WrittenOn = new DateTime(2022, 6, 11),
				AddedOn = DateTime.Now,
				AuthorId = Author.Id,
				PublisherId = Publisher.Id,
			};
		}
    }
}
