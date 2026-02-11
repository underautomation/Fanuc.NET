## FTP Module

- **PositionRegister**: Introduced new `PositionRegister` class to handle both Cartesian and Joint positions
  - Replaces `CartesianPositionVariable` in position registers context
  - Automatically detects position type (Cartesian vs Joint) during parsing
  - Provides unified access through `CartesianPosition` and `JointsPosition` properties
- **PosregFile**: Updated `$POSREG` variable type to use `PositionRegister` instead of `CartesianPositionVariable`
- **FtpListItem.Size**: Enhanced documentation clarifying that file size is only available for specific file types (_.tp, _.df)

## SNPX Module

- **PositionRegisters**: Added `Read(int index)` method for direct position register access
- **PositionSystemVariables**: Added `Read(string index)` method for direct position variable access
- **Flags**: Added `CreateBatchAssignment(int startIndex, int count)` convenience method

## Common Types

- **Position**: Added `ToString()` override for better debugging and logging output

## Internal Improvements

- Updated code generation logic to properly handle position registers (both Cartesian and Joint configurations)
- Improved JointPositionVariable parsing comments for clarity
- License trial period auto-start disabled for showcase applications
