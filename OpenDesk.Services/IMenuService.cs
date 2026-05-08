using System.Collections.Generic;
using OpenDesk.Domain.Models.Menus;
using OpenDesk.Persistance.Common;

namespace OpenDesk.Services
{
    public interface IMenuService
    {
        IEnumerable<MenuItem> GetMenuItemsByGroupCode(string menuItemGroupCode);
        IEnumerable<MenuItem> GetMenuItems();
        IEnumerable<MenuItem> GetMenuItemsWithPortions();
        IEnumerable<MenuItemData> GetMenuItemData();
        IEnumerable<ScreenMenu> GetScreenMenus();
        IEnumerable<string> GetMenuItemNames();
        IEnumerable<string> GetMenuItemGroupCodes();
        IEnumerable<string> GetMenuItemTags();
        MenuItem GetMenuItemById(int id);
    }
}
