## CGTP Source Code Editing and Program Listing

New CGTP methods for editing TP program source code directly on the controller, and listing programs. These features require firmware **V9.10+** (source editing) or standard CGTP support (listing).

### List programs

Retrieve all TP or Karel programs on the controller, filtered by type and sub-type.

```csharp
// List all TP programs (all sub-types)
string[] tpPrograms = robot.Cgtp.ListTpPrograms();

// List programs with a specific type and sub-type
string[] macros = robot.Cgtp.ListPrograms(CgtpProgramType.Tp, CgtpProgramSubType.Macro);
```

### Source code editing

Insert, replace, or delete lines in a TP program on the controller.

```csharp
// Insert a new line before line 3
robot.Cgtp.InsertSourceLine("MY_PROGRAM", "L P[5] 100mm/sec FINE", 3);

// Replace line 5
robot.Cgtp.ReplaceSourceLine("MY_PROGRAM", "J P[1] 50% FINE", 5);

// Delete 2 lines starting at line 4
robot.Cgtp.DeleteSourceLines("MY_PROGRAM", 4, 2);
```
