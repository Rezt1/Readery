using Readery.Core.Models.Author;
using Readery.Domain.Data.Models;

namespace Readery.Core.Contracts
{
    public interface IAuthorService
    {
        public Task CreateAuthorAsync(BecomeAuthorViewModel model, string userId);
    }
}
