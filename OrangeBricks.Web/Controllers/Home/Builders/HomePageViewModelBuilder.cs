using OrangeBricks.Web.Controllers.Home.ViewModels;
using OrangeBricks.Web.Models;
using System.Linq;

namespace OrangeBricks.Web.Controllers.Home.Builders
{
    public class HomePageViewModelBuilder
    {
        private readonly IOrangeBricksContext _context;

        public HomePageViewModelBuilder(IOrangeBricksContext context)
        {
            _context = context;
        }

        public HomePageViewModel Build(string buyerUserId)
        {
            var hasAcceptedOffers = _context
                                    .Offers
                                    .Where(o => o.BuyerUserId == buyerUserId && o.Status == OfferStatus.Accepted)
                                    .Any();

            return new HomePageViewModel
            {
                HasAcceptedOffer = hasAcceptedOffers
            };
        }
    }
}