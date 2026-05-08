using System.ComponentModel.Composition;
using OpenDesk.Domain.Models.Menus;
using OpenDesk.Presentation.Common.ModelBase;
using OpenDesk.Services;

namespace OpenDesk.Modules.MenuModule
{
    [Export, PartCreationPolicy(CreationPolicy.NonShared)]
    class MenuItemPriceDefinitionListViewModel : EntityCollectionViewModelBase<MenuItemPriceDefinitionViewModel, MenuItemPriceDefinition>
    {
        private readonly IPriceListService _priceListService;

        [ImportingConstructor]
        public MenuItemPriceDefinitionListViewModel(IPriceListService priceListService)
        {
            _priceListService = priceListService;
        }

        protected override void BeforeDeleteItem(MenuItemPriceDefinition item)
        {
            _priceListService.DeleteMenuItemPricesByPriceTag(item.PriceTag);
        }
    }
}
