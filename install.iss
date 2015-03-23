#define MyAppName "Ouatelse"
#define MyAppVersion "1.0"
#define MyAppPublisher "IutInfoBdx S4A DreamTeam"
#define MyAppURL "http://www.ouatelse.fr/"
#define MyAppExeName "Ouatelse.exe"

[Setup]
AppId={{D5F45C40-D63E-44BB-B6F1-68435909FD23}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
OutputDir=\\psf\Home\IUT\S4\
OutputBaseFilename=setup_ouatelse
SetupIconFile=\\psf\Home\IUT\S4\Ouatelse\OuatelseIcon.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "french"; MessagesFile: "compiler:Languages\French.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "\\psf\Home\IUT\S4\Ouatelse\Ouatelse\Ouatelse\bin\Debug\Ouatelse.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\psf\Home\IUT\S4\Ouatelse\Ouatelse\Ouatelse\bin\Debug\Common.Logging.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\psf\Home\IUT\S4\Ouatelse\Ouatelse\Ouatelse\bin\Debug\IrisALS.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\psf\Home\IUT\S4\Ouatelse\Ouatelse\Ouatelse\bin\Debug\libeay32.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\psf\Home\IUT\S4\Ouatelse\Ouatelse\Ouatelse\bin\Debug\libgcc_s_dw2-1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\psf\Home\IUT\S4\Ouatelse\Ouatelse\Ouatelse\bin\Debug\mingwm10.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\psf\Home\IUT\S4\Ouatelse\Ouatelse\Ouatelse\bin\Debug\Pechkin.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\psf\Home\IUT\S4\Ouatelse\Ouatelse\Ouatelse\bin\Debug\ssleay32.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\psf\Home\IUT\S4\Ouatelse\Ouatelse\Ouatelse\bin\Debug\System.Data.SQLite.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\psf\Home\IUT\S4\Ouatelse\Ouatelse\Ouatelse\bin\Debug\wkhtmltox0.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\psf\Home\IUT\S4\Ouatelse\MySql.Data.dll"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

