# ePnpGui

This is a Windows application (implemented using WinForms & C#) that has all the functionality the command line PnPUtil provides:
-	Adds a driver package to the driver store.
-	Installs a driver package on the computer.
-	Deletes a driver package from the driver store.
-	Enumerates the driver packages that are currently in the driver store. Only driver packages that are not in-box packages are listed.

In addition, it allows one to:
-	Open the Folder Location of the selected driver.
-	Check old drivers.
-	Save the list of drivers to a CVS file. 

![alt text](https://github.com/ebuculei/ePnpGui/blob/master/ePnpGui.jpg)

Requirements:
- .NET Framework 4.5.1 or newer
- Windows 7 or newer
- Windows Server 2016 or newer 

To build the application, open ePnpGui.sln in Visual Studio 2017, 2019, or 2022.
