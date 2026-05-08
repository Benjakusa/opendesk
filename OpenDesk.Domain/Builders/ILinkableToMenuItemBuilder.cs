using OpenDesk.Domain.Models.Menus;

namespace OpenDesk.Domain.Builders
{
    public interface ILinkableToMenuItemBuilder<T> where T : ILinkableToMenuItemBuilder<T>
    {
        void Link(MenuItem menuItem);
        MenuItemBuilderFor<T> CreateMenuItem(string menuItemName);
    }
}