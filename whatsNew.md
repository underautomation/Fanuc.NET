## SNPX: Flag Comments Support

Added support for reading and writing Flag comments through SNPX.

## CGTP: New Capabilities and Improvements

- Enabled CGTP I/O operations in `CgtpClientBase`:
  - Read I/O values
  - Write I/O values
  - Read I/O simulation status
  - Simulate/unsimulate I/O
  - Read current Cartesian position (X, Y, Z, W, P, R coordinates and configuration) of a motion group
  - Read current joint angles (J1-J6) of a motion group

## SNPX: Null-Terminated String Handling Fix

Improved string decoding by trimming trailing null terminators (`\0`) across SNPX string-related reads.

This prevents issues with null-terminated strings in scenarios such as:

- String registers
- Comments (including batch reads)
- String system variables
