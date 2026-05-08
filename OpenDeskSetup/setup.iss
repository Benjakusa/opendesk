#include "scripts\products.iss"

#include "scripts\products\winversion.iss"
#include "scripts\products\fileversion.iss"
#include "scripts\products\msi31.iss"
#include "scripts\lgpl.iss"
#include "scripts\products\ssce40.iss"
#include "scripts\products\dotnetfx40client.iss"
#include "scripts\products\wic.iss"

[CustomMessages]
win2000sp3_title=Windows 2000 Service Pack 3
winxpsp2_title=Windows XP Service Pack 2
winxpsp3_title=Windows XP Service Pack 3
en.full_setup=Full Setup
en.compact_setup=Compact Setup
en.custom_setup=Custom Setup
en.sample_data=Sample Data
en.handheld_terminal_app=Handheld terminal app
en.ce_install_sp3_required=Compact SQL 4.0 removed from packages list because Service Pack 3 required for Compact SQL 4.0 installation. Program will run with TXT database.

en.InstallService=install WindowsService %1
en.StartService=start WindowsService %1

tr.full_setup=Tam Kurulum
tr.compact_setup=Normal Kurulum
tr.custom_setup=�zel Kurulum
tr.sample_data=�rnek Veri
tr.handheld_terminal_app=El terminali uygulamas�
tr.ce_install_sp3_required=Compact SQL 4.0 �al��t�rmak i�in Service Pack 3 gerekti�inden kurulum listesinden kald�r�ld�. Program TXT dosya veritaban� �zerinden �al��acak.

#define Version "3.0.35"
#define FileVersion "3035"
#define DbVersion "24"

#define VersionInfo "3.0.35 BETA"
#define VersionTime GetDateTimeString('yyyy-mm-dd hhnn', '-', ':');

[Setup]
AppName=OpenDesk
Uninstallable=true
DirExistsWarning=no
CreateAppDir=true
OutputDir=bin
OutputBaseFilename=OpenDeskSetup{#FileVersion}_Beta
SourceDir=.
AppCopyright=Copyright � A��k Yaz�l�m Platformu 2013
AppVerName=OpenDesk POS {#VersionInfo}

DefaultGroupName=OpenDesk3
AllowNoIcons=true
AppPublisher=A��k Yaz�l�m
AppVersion={#VersionInfo}
UninstallDisplayIcon={app}\OpenDesk.Presentation.exe
UninstallDisplayName=OpenDesk3
UsePreviousGroup=true
UsePreviousAppDir=true
DefaultDirName={pf}\OpenDesk3
VersionInfoVersion={#Version}
VersionInfoCompany=A��k Yaz�l�m
VersionInfoCopyright=Copyright � AYP 2010
ShowUndisplayableLanguages=false
LanguageDetectionMethod=locale
InternalCompressLevel=fast
SolidCompression=true
Compression=lzma/fast

;required by products
PrivilegesRequired=admin
ArchitecturesAllowed=
VersionInfoProductName=OpenDesk POS Setup
AppID={{9447659F-1795-44B2-B8A2-E0FA049A5F6E}


[Languages]
Name: en; MessagesFile: compiler:Default.isl
Name: de; MessagesFile: compiler:Languages\German.isl
Name: tr; MessagesFile: compiler:Languages\Turkish.isl

[Tasks]
Name: desktopicon; Description: {cm:CreateDesktopIcon}; GroupDescription: {cm:AdditionalIcons}; Languages: ; Components: 
Name: quicklaunchicon; Description: {cm:CreateQuickLaunchIcon}; GroupDescription: {cm:AdditionalIcons}; Flags: unchecked

[Files]
Source: src\EntityFramework.dll; DestDir: {app}
Source: src\Microsoft.Practices.Prism.dll; DestDir: {app}
Source: src\Microsoft.Practices.Prism.MefExtensions.dll; DestDir: {app}
Source: src\Microsoft.Practices.Prism.Interactivity.dll; DestDir: {app}
Source: src\Microsoft.Practices.ServiceLocation.dll; DestDir: {app}
Source: src\PropertyTools.dll; DestDir: {app}; Flags: ignoreversion
Source: src\PropertyTools.Wpf.dll; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.Domain.dll; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.Infrastructure.Data.dll; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.Infrastructure.dll; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.MessagingServer.exe; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.MessagingServerServiceTool.exe; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.MessagingServer.WindowsService.exe; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.Modules.AccountModule.dll; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.Modules.AutomationModule.dll; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.Modules.BasicReports.dll; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.Modules.BasicReports.pdb; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.Modules.DepartmentModule.dll; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.Modules.EntityModule.dll; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.Modules.InventoryModule.dll; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.Modules.LoginModule.dll; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.Modules.ManagementModule.dll; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.Modules.MarketModule.dll; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.Modules.MenuModule.dll; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.Modules.ModifierModule.dll; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.Modules.NavigationModule.dll; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.Modules.PaymentModule.dll; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.Modules.PosModule.dll; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.Modules.PrinterModule.dll; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.Modules.SettingsModule.dll; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.Modules.TaskModule.dll; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.Modules.TicketModule.dll; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.Modules.UserModule.dll; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.Modules.WorkperiodModule.dll; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.Persistance.DBMigration.dll; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.Persistance.dll; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.Presentation.Common.dll; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.Presentation.Controls.dll; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.Presentation.exe; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.Presentation.exe.config; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.Presentation.exe.manifest; DestDir: {app}; Flags: ignoreversion
Source: src\AxInterop.cidv5callerid.dll; DestDir: {app}; Flags: ignoreversion; Components: cid
Source: src\Interop.cidv5callerid.dll; DestDir: {app}; Flags: ignoreversion; Components: cid
Source: src\OpenDesk.Modules.CidMonitor.dll; DestDir: {app}; Flags: ignoreversion; Components: cid
Source: src\OpenDesk.Presentation.ViewModels.dll; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.Presentation.Services.dll; DestDir: {app}; Flags: ignoreversion
Source: src\OpenDesk.Services.dll; DestDir: {app}; Flags: ignoreversion
Source: src\System.Windows.Interactivity.dll; DestDir: {app}
Source: src\Images\apple-icon.png; DestDir: {app}\Images\
Source: src\Images\apple.ico; DestDir: {app}\Images\
Source: src\Images\empty.png; DestDir: {app}\Images\
Source: src\Images\logo.png; DestDir: {app}\Images\; Flags: onlyifdoesntexist
Source: src\Imports\menu.txt; DestDir: {app}\Imports\; Components: veri
Source: src\Imports\table.txt; DestDir: {app}\Imports\; Components: veri
Source: src\Imports\menu_tr.txt; DestDir: {app}\Imports\; Components: veri
Source: src\Imports\table_tr.txt; DestDir: {app}\Imports\; Components: veri
Source: src\FlexButton.dll; DestDir: {app}; Flags: ignoreversion
Source: src\FastButton.dll; DestDir: {app}; Flags: ignoreversion
Source: src\DataGridFilterLibrary.dll; DestDir: {app}; Flags: ignoreversion
Source: src\FluentValidation.dll; DestDir: {app}; Flags: ignoreversion
Source: src\FluentMigrator.dll; DestDir: {app}; Flags: ignoreversion
Source: src\FluentMigrator.Runner.dll; DestDir: {app}; Flags: ignoreversion
Source: src\GongSolutions.Wpf.DragDrop.dll; DestDir: {app}; Flags: ignoreversion
Source: src\Omu.ValueInjecter.dll; DestDir: {app}; Flags: ignoreversion
Source: src\Gma.QrCodeNet.Encoding.Net35.dll; DestDir: {app}; Flags: ignoreversion
Source: src\ICSharpCode.AvalonEdit.dll; DestDir: {app}; Flags: ignoreversion
Source: src\FluentScript.dll; DestDir: {app}; Flags: ignoreversion
Source: src\Stateless.dll; DestDir: {app}; Flags: ignoreversion
Source: src\Zen.Barcode.Core.dll; DestDir: {app}; Flags: ignoreversion
Source: src\migrate.txt; DestDir: {userappdata}\Ozgu Tech\OpenDesk3; Flags: ignoreversion
Source: C:\Windows\Fonts\lucon.ttf; DestDir: {fonts}; Flags: onlyifdoesntexist uninsneveruninstall; FontInstall: Lucida Console
Source: src\OpenDesk.Localization.dll; DestDir: {app}; Flags: ignoreversion
Source: src\tr\OpenDesk.Localization.resources.dll; DestDir: {app}\tr\; Flags: ignoreversion
Source: src\it\OpenDesk.Localization.resources.dll; DestDir: {app}\it\; Flags: ignoreversion
Source: src\pt-BR\OpenDesk.Localization.resources.dll; DestDir: {app}\pt-BR\; Flags: ignoreversion
Source: src\hr\OpenDesk.Localization.resources.dll; DestDir: {app}\hr\; Flags: ignoreversion
Source: src\ar\OpenDesk.Localization.resources.dll; DestDir: {app}\ar\; Flags: ignoreversion
Source: src\hu\OpenDesk.Localization.resources.dll; DestDir: {app}\hu\; Flags: ignoreversion
Source: src\es\OpenDesk.Localization.resources.dll; DestDir: {app}\es\; Flags: ignoreversion
Source: src\id\OpenDesk.Localization.resources.dll; DestDir: {app}\id\; Flags: ignoreversion
Source: src\el\OpenDesk.Localization.resources.dll; DestDir: {app}\el\; Flags: ignoreversion
Source: src\zh-CN\OpenDesk.Localization.resources.dll; DestDir: {app}\zh-CN\; Flags: ignoreversion
Source: src\sq\OpenDesk.Localization.resources.dll; DestDir: {app}\sq\; Flags: ignoreversion
Source: src\de\OpenDesk.Localization.resources.dll; DestDir: {app}\de\; Flags: ignoreversion
Source: src\cs\OpenDesk.Localization.resources.dll; DestDir: {app}\cs\; Flags: ignoreversion
Source: src\nl\OpenDesk.Localization.resources.dll; DestDir: {app}\nl\; Flags: ignoreversion
Source: src\he\OpenDesk.Localization.resources.dll; DestDir: {app}\he\; Flags: ignoreversion
Source: src\fr\OpenDesk.Localization.resources.dll; DestDir: {app}\fr\; Flags: ignoreversion
Source: src\ru-RU\OpenDesk.Localization.resources.dll; DestDir: {app}\ru-RU\; Flags: ignoreversion
Source: src\da\OpenDesk.Localization.resources.dll; DestDir: {app}\da\; Flags: ignoreversion
Source: src\fa\OpenDesk.Localization.resources.dll; DestDir: {app}\fa\; Flags: ignoreversion
Source: src\tk-TM\OpenDesk.Localization.resources.dll; DestDir: {app}\tk-TM\; Flags: ignoreversion
                                                              
[Components]
Name: pos; Description: OpenDesk POS; Types: full compact custom; Flags: fixed
Name: terminal; Description: {cm:handheld_terminal_app}; Languages: ; Types: full
Name: sqlce; Description: Compact SQL 4.0; Languages: ; Types: full compact custom
Name: veri; Description: {cm:sample_data}; Languages: ; Types: full compact custom
Name: cid; Description: Caller Id; Languages: ; Types: full custom

[Types]
Name: compact; Description: {cm:compact_setup}
Name: full; Description: {cm:full_setup}
Name: custom; Description: {cm:custom_setup}; Flags: iscustom

[Icons]
Name: {group}\OpenDesk POS 3; Filename: {app}\OpenDesk.Presentation.exe
Name: {group}\{cm:UninstallProgram,OpenDesk POS}; Filename: {uninstallexe}
Name: {commondesktop}\OpenDesk3; Filename: {app}\OpenDesk.Presentation.exe; IconIndex: 0; Flags: createonlyiffileexists; Components: 
Name: {commondesktop}\OpenDesk Terminal; Filename: {app}\OpenDesk.Presentation.Terminal.exe; Flags: createonlyiffileexists
Name: {userappdata}\Microsoft\Internet Explorer\Quick Launch\OpenDesk POS; Filename: {app}\OpenDesk.Presentation.exe; Tasks: quicklaunchicon
Name: {group}\OpenDesk Data; Filename: {commonappdata}\Ozgu Tech\OpenDesk3\

[Run]
Filename: {app}\OpenDesk.Presentation.exe; Description: {cm:LaunchProgram,OpenDesk POS}; Flags: nowait postinstall skipifsilent unchecked
Filename: {app}\OpenDesk.MessagingServerServiceTool.exe; Description: {cm:LaunchProgram,MessagingServer ServiceTool}; Flags: nowait postinstall skipifsilent unchecked runascurrentuser
Filename: {app}\OpenDesk.MessagingServer.exe; Description: {cm:LaunchProgram,MessagingServer (Standalone)}; Flags: nowait postinstall skipifsilent unchecked
;Filename: {app}\OpenDesk.MessagingServer.WindowsService.exe; Parameters: "--install"; Description: {cm:InstallService,MessagingServer.WindowsService}; Flags: nowait postinstall skipifsilent unchecked*/
;Filename: {app}\OpenDesk.MessagingServer.WindowsService.exe; Parameters: "--start"; Description: {cm:StartService,MessagingServer.WindowsService}; Flags: nowait postinstall skipifsilent unchecked

;[UninstallRun]
;Filename: {app}\OpenDesk.MessagingServer.exe; Parameters: "--uninstall"; Flags: runascurrentuser

[Code]
function CreateVersion(): boolean;
var
  fileName : string;
  lines : TArrayOfString;
begin
  Result := true;
  fileName := ExpandConstant('{commonappdata}\Ozgu Tech\OpenDesk3\version.dat');
  SetArrayLength(lines, 5);
  lines[0] := ExpandConstant('Version={#Version}');
  lines[1] := ExpandConstant('FileVersion={#FileVersion}');
  lines[2] := ExpandConstant('DbVersion={#DbVersion}');
  lines[3] := ExpandConstant('AppVersion={#VersionInfo}');
  lines[4] := ExpandConstant('VersionTime={#VersionTime}');
  
  Result := SaveStringsToFile(filename,lines,false);
  
  exit;
end;
procedure CurStepChanged(CurStep: TSetupStep);
begin
  if  CurStep=ssPostInstall then
    begin
         CreateVersion();
    end
end;
 
procedure CurPageChanged(CurPageID: Integer);
begin
if (CurPageId = wpSelectProgramGroup) then
  begin
    RemoveProducts();
    msi31('3.0');
    wic();
    dotnetfx40client();
    if IsComponentSelected('sqlce') then
    if not minwinspversion(5, 1, 3) then begin
		MsgBox(FmtMessage(CustomMessage('ce_install_sp3_required'), [CustomMessage('winxpsp3_title')]), mbError, MB_OK);
    end else begin
		ssce40();
    end;
  end;
end;

procedure InitializeWizard();
begin
  LGPL_InitializeWizard();
end;

function InitializeSetup(): Boolean;
begin
	initwinversion();

	if not minwinspversion(5, 0, 3) then begin
		MsgBox(FmtMessage(CustomMessage('depinstall_missing'), [CustomMessage('win2000sp3_title')]), mbError, MB_OK);
		exit;
	end;
	if not minwinspversion(5, 1, 2) then begin
		MsgBox(FmtMessage(CustomMessage('depinstall_missing'), [CustomMessage('winxpsp2_title')]), mbError, MB_OK);
		exit;
	end;

	//if (not iis()) then exit;

	//msi20('2.0');

	//ie6('5.0.2919');

	//dotnetfx11();
	//dotnetfx11lp();
	//dotnetfx11sp1();

	//kb835732();

	//if (minwinversion(5, 0) and minspversion(5, 0, 4)) then begin
	//	dotnetfx20sp1();
		//dotnetfx20sp1lp();
	//end else begin
	//	dotnetfx20();
		//dotnetfx20lp();
	//end;

	//dotnetfx35();
	//dotnetfx35lp();
	//dotnetfx35sp1();
	//dotnetfx35sp1lp();

	//mdac28('2.7');
	//jet4sp8('4.0.8015');

  Result := true;
end;

[Dirs]
Name: {app}\Images
Name: {app}\Imports
Name: {app}\tr
Name: {app}\it
Name: {app}\pt-BR
Name: {app}\hr
Name: {app}\ar
Name: {app}\hu
Name: {app}\es
Name: {app}\id
Name: {app}\el
Name: {app}\zh-CN
Name: {app}\sq
Name: {app}\de
Name: {app}\cs
Name: {app}\nl
Name: {app}\he
Name: {app}\fr
Name: {app}\ru-RU

Name: {commonappdata}\Ozgu Tech\OpenDesk3

[Registry]
Root: HKLM; Subkey: SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION; ValueType: dword; ValueName: opendesk.presentation.exe; ValueData: 10000

