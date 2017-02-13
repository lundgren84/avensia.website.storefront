using EPiServer.Core;

namespace AvensiaStoreFront.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
