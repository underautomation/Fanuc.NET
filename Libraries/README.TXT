UnderAutomation SDK
===================

Contents
--------
This archive contains the UnderAutomation SDK assemblies (DLLs) compiled for
several .NET target framework versions. Pick the subfolder that matches the
.NET version used by your project.

Unblocking the files on Windows
-------------------------------
On Windows, a file extracted from a downloaded archive may be blocked by the
operating system. A blocked DLL can be locked and cause difficulties when you
try to use it (it may fail to load or raise security exceptions at runtime).
To unblock a file:
  1. Right-click the file in Windows Explorer.
  2. Select "Properties".
  3. Check the "Unblock" checkbox at the bottom of the "General" tab.
  4. Click "OK".

Tip: unblock the ZIP archive itself BEFORE extracting it (same Properties /
Unblock procedure on the .zip file). All extracted files are then already
unblocked, so you do not have to unblock each DLL one by one.

Registering your license
------------------------
To use this SDK you must call the RegisterLicense method with the license
information obtained through the following form. Without it you will not be able
to connect to the robot and an exception will be thrown:
  https://underautomation.com/license

Perpetual license and source code
---------------------------------
To obtain a perpetual license or the source code of this DLL:
  https://underautomation.com/order

Support and sales
-----------------
For any technical or commercial support question, or to place an order:
  contact@underautomation.com

Thank you for your trust.
