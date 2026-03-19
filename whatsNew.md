# SNPX : Comments and Simulation Status

## New feature : Comments

New `Comments` accessor allows reading and writing comments of registers, position registers, string registers and I/O signals via SNPX.

```csharp
// Read the comment of R[1] (default 16 characters)
string comment = robot.Snpx.Comments.Read(CommentType.Register, 1);

// Read the comment of DI[3] with a custom length
string diComment = robot.Snpx.Comments.Read(CommentType.DI, 3);

// Write a comment to PR[5]
robot.Snpx.Comments.Write(CommentType.PositionRegister, 5, "My position");
```

Supported types: `Register`, `PositionRegister`, `StringRegister`, `DI`, `DO`, `RI`, `RO`, `UI`, `UO`, `SI`, `SO`, `WI`, `WO`, `WSI`, `WSO`, `GI`, `GO`, `AI`, `AO`.

## New feature : Simulation Status

New `SimulationStatus` accessor allows reading and writing the simulation state of I/O signals via SNPX.

```csharp
// Check if DI[1] is simulated
bool isSimulated = robot.Snpx.SimulationStatus.Read(SimulationType.DI, 1);

// Enable simulation on RO[2]
robot.Snpx.SimulationStatus.Write(SimulationType.RO, 2, true);

// Disable simulation on GI[5]
robot.Snpx.SimulationStatus.Write(SimulationType.GI, 5, false);
```

Supported types: `DI`, `DO`, `RI`, `RO`, `WI`, `WO`, `WSI`, `WSO`, `GI`, `GO`, `AI`, `AO`.

# Telnet : Fix premature response finalization on non-English controllers

Fixed an issue where Telnet KCL commands (e.g. `GetVariable`, `SetVariable`) could fail on non-English controllers (Chinese, Japanese...) due to intermediate VT100 display-update frames being incorrectly interpreted as the end of a response.

On some controllers, status bar refresh frames (containing only ANSI escape sequences) arrive before the actual command response data. These empty frames were causing the result to be finalized prematurely, leading to missing or empty values.

A new mechanism now allows multi-frame results (`GetVariableResult`, `SetVariableResult`, `BreakpointsResult`) to defer finalization until meaningful data has actually been received.

# SNPX : String registers span and fixes

## New feature : String registers span

New `StringRegistersSpan` accessor allows reading and writing substrings of string registers (SR[]) with control over start index and length.

```csharp
// Read 10 characters starting at position 4 from SR[1]
string value = robot.Snpx.StringRegistersSpan.Read(registerIndex: 1, stringLength: 10, stringStartIndex: 4);

// Write a substring into SR[2]
robot.Snpx.StringRegistersSpan.Write(registerIndex: 2, value: "Hello", stringLength: 10, stringStartIndex: 0);
```

## Fix for writing empty strings

Allow SNPX to write empty strings to string variables and string registers. String encoding now uses fixed-length byte buffers, preventing issues with empty or odd-length strings.

## Fix missing assignable elements

`NumericRegistersInt16`, `NumericRegistersInt32`, `StringRegistersSpan` and `Flags` are now correctly included in SNPX assignable elements, ensuring `ClearAssignments()` and `GetAssignments()` cover all element types.
