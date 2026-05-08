using System.Collections.Generic;
using OpenDesk.Domain.Models.Menus;
using OpenDesk.Persistance;
using OpenDesk.Persistance.Common;

namespace OpenDesk.Services
{
    public interface IPriceListService
    {
        void DeleteMenuItemPricesByPriceTag(string priceTag);
        void UpdatePriceTags(MenuItemPriceDefinition model);
        IEnumerable<string> GetTags();
        IEnumerable<PriceData> CreatePrices();
        void UpdatePrices(IList<PriceData> prices);
    }
}
