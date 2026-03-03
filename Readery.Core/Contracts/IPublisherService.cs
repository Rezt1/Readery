using Readery.Core.Models.Publisher;

namespace Readery.Core.Contracts
{
	public interface IPublisherService
	{
		public Task<List<PublisherViewModel>> GetPublishersAsync();
	}
}
