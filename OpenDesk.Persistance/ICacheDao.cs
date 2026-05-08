using System.Collections.Generic;
using OpenDesk.Domain.Models.Accounts;
using OpenDesk.Domain.Models.Automation;
using OpenDesk.Domain.Models.Entities;
using OpenDesk.Domain.Models.Inventory;
using OpenDesk.Domain.Models.Menus;
using OpenDesk.Domain.Models.Settings;
using OpenDesk.Domain.Models.Tasks;
using OpenDesk.Domain.Models.Tickets;

namespace OpenDesk.Persistance
{
    public interface ICacheDao
    {
        void ResetCache();
        IEnumerable<Entity> GetEntities(int entitiyTypeId);
        IEnumerable<MenuItem> GetMenuItems();
        IEnumerable<ProductTimer> GetProductTimers();
        IEnumerable<OrderTagGroup> GetOrderTagGroups();
        IEnumerable<AccountTransactionType> GetAccountTransactionTypes();
        IEnumerable<EntityType> GetEntityTypes();
        IEnumerable<AccountType> GetAccountTypes();
        IEnumerable<AccountTransactionDocumentType> GetAccountTransactionDocumentTypes();
        IEnumerable<State> GetStates();
        IEnumerable<PrintJob> GetPrintJobs();
        IEnumerable<PaymentType> GetPaymentTypes();
        IEnumerable<ChangePaymentType> GetChangePaymentTypes();
        IEnumerable<TicketTagGroup> GetTicketTagGroups();
        IEnumerable<AutomationCommand> GetAutomationCommands();
        IEnumerable<CalculationSelector> GetCalculationSelectors();
        IEnumerable<CalculationType> GetCalculationTypes();
        IEnumerable<AccountScreen> GetAccountScreens();
        IEnumerable<ScreenMenu> GetScreenMenus();
        IEnumerable<EntityScreen> GetEntityScreens();
        IEnumerable<TicketType> GetTicketTypes();
        IEnumerable<TaskType> GetTaskTypes();
        IEnumerable<ForeignCurrency> GetForeignCurrencies();
        IEnumerable<Department> GetDepartments();
        Entity GetEntityByName(int entityTypeId, string entityName);
        IEnumerable<TaxTemplate> GetTaxTemplates();
        IEnumerable<Warehouse> GetWarehouses();
        IEnumerable<InventoryTransactionType> GetInventoryTransactionTypes();
        IEnumerable<AppRule> GetRules();
        IEnumerable<AppAction> GetActions();
    }
}
