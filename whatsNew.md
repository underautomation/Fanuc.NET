# What's New

## New CGTP Protocol Support

A new **CGTP Web Server** client has been added, providing access to the HTTP-based RPC interface available on FANUC controllers (default port: 3080).

This lightweight, firewall-friendly protocol complements the existing SNPX, RMI, Telnet, and FTP connections and is **enabled by default** when connecting.

Feature:

- Create, delete, rename programs
- Read and write program attributes: comment, owner, stack size, write-protection, ignore-pause flag, and sub-type
- Run, abort, and pause programs
- Select a program and set the cursor to a specific line
- Change the active TP program
- Read and write system and program variables by name
- List files on the controller (`MD:` or other devices)
- Read file contents as text

A `CgtpClient` class is available for direct use without a `FanucRobot` instance.

---

## Connection Parameters Changes

- **Telnet** and **FTP** are now **disabled by default**, enable them explicitly via `ConnectionParameters.Telnet.Enable` and `ConnectionParameters.Ftp.Enable`
- **CGTP** is **enabled by default**, disable via `ConnectionParameters.Cgtp.Enable = false`

---

## SNPX Fixes

- Null terminators (`\0`) are now correctly trimmed from string values returned when reading string registers and string variables

---

## SNPX String Registers Simplification

- `StringRegistersSpan` has been removed from the public SDK API because it made SNPX usage harder to understand.
- Use `StringRegisters` for string register read/write.
- Important: `StringRegisters.StringLength` is static. Set it once before any string register read/write, and do not change it while the SDK is running.
- Default value remains `80`.

Examples:

```csharp
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.Snpx.Internal;

var robot = new FanucRobot();
robot.Connect("192.168.0.10");

// Configure once before any SR[] read/write.
StringRegisters.StringLength = 100; // default size is 80

// Write and read a string register.
robot.Snpx.StringRegisters.Write(1, "HELLO FANUC");
string value = robot.Snpx.StringRegisters.Read(1);
```
