# OpenDesk POS

Touch-screen Point of Sale software for restaurants, bars, and cafes. Rebranded and maintained by OpenDesk under GPLv3.

## Features

- **Order Management** – Create, split, merge, and transfer tickets; manage modifiers and order tags
- **Menu Management** – Products, departments, menu groups, and price lists
- **Payment Processing** – Cash, credit card, gift cards, and custom payment methods
- **Inventory Control** – Track stock levels, recipes, and ingredient usage
- **Reporting** – Sales reports, profit analysis, and work period summaries
- **Customer Display** – Pole display and customer-facing screen support
- **Printer Integration** – Kitchen and receipt printers with auto-cut and open drawer
- **Multi-User** – Role-based permissions with PIN login
- **Automation Engine** – Rule-based triggers, scripts, and actions
- **Messaging Server** – Push notifications between terminals
- **Entity Management** – Customers, vendors, and loyalty programs
- **Multi-Language** – 20+ language translations included
- **API Server** – RESTful HTTP API for external integrations

## System Requirements

- Windows XP SP3 or later
- .NET Framework 4.0 Client Profile
- SQL Server Compact 4.0 (optional – can use TXT file database)

## Installation

### Using the Installer

Run `OpenDeskSetup*.exe` from the `OpenDeskSetup/bin/` directory (requires Inno Setup to build).

### Building from Source

1. Open `OpenDesk.sln` in Visual Studio 2012+ (or any editor with MSBuild support)
2. Restore NuGet packages if needed (none required – all dependencies in `Lib/`)
3. Build solution (x86 target recommended)
4. Run `OpenDesk.Presentation.exe`

### Database Setup

- On first launch, the application guides you through database creation
- Supports both SQL Server Compact (.sdf file) and plain text file modes
- Database migrations are handled automatically on version upgrades

## Project Structure

| Layer | Projects |
|---|---|
| Presentation | `OpenDesk.Presentation`, `OpenDesk.Presentation.Common`, `OpenDesk.Presentation.Controls`, `OpenDesk.Presentation.Services`, `OpenDesk.Presentation.ViewModels` |
| Modules | `OpenDesk.Modules.*` (Account, Automation, BasicReports, Department, Entity, Inventory, Login, Management, Market, Menu, Modifier, Navigation, Payment, Pos, Printer, Settings, Task, Ticket, User, Workperiod) |
| Services | `OpenDesk.Services` |
| Domain | `OpenDesk.Domain` |
| Persistence | `OpenDesk.Persistance`, `OpenDesk.Persistance.DBMigration` |
| Infrastructure | `OpenDesk.Infrastructure`, `OpenDesk.Infrastructure.Data` |
| API | `OpenDesk.ApiServer` |
| Messaging | `OpenDesk.MessagingServer`, `OpenDesk.MessagingServer.WindowsService` |

## License

GNU General Public License v3.0. See `OpenDeskSetup/src/gpl-3.0.txt`.

Original copyright (c) 2012 Emre Eren. Rebranded and maintained by OpenDesk under GPLv3.
