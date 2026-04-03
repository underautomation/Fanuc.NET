## Kinematics via CGTP

- New `InvertKinematics` method: compute inverse kinematics on the controller, converting a Cartesian position to joint angles.
- New `ForwardKinematics` method: compute forward kinematics on the controller, converting joint angles to a Cartesian position.
- Both methods execute the computation on the controller itself, ensuring results match the robot's actual kinematic model.

## Batch variable read/write via CGTP

- New `ReadBatchVariables(CgtpBatchVariables)` method: read multiple variables from the controller in a single request.
- New `WriteBatchVariables(CgtpBatchVariables)` method: write multiple variables to the controller in a single request.
- New `CgtpBatchVariables` collection (implements `IList<ICgtpBatchVariable>`) with convenience methods to add variables:
  - `AddNumericRegister(index)`, `AddNumericRegisterAsInteger(index, value)`, `AddNumericRegisterAsReal(index, value)` for numeric registers R[].
  - `AddStringRegister(index)`, `AddStringRegisterWithValue(index, value)` for string registers SR[].
  - `AddPositionRegister(index)`, `AddPositionRegisterAsCartesian(index, ...)`, `AddPositionRegisterAsJoint(index, ...)` for position registers PR[].
  - `AddVariable(name, program)` for any named variable.
- New typed variable classes: `CgtpNumericRegister`, `CgtpStringRegister`, `CgtpPositionRegister`, `CgtpVariable`, all implementing `ICgtpBatchVariable`.
- `CgtpVariable` exposes typed getters/setters: `IntegerValue`, `RealValue`, `BooleanValue`, `StringValue`, `CartesianPositionValue`, `JointPositionValue`, `VectorValue`, `ConfigurationValue`, `StructureValue`.
- `CgtpVariable.StructureValue` returns a tree of `CgtpStructureField` for structured variables (FIELD/ARRAY nodes).
- After a batch read, each variable exposes `Exists`, `IsUninitialized`, and `IsReadOnly` status properties.
- `CgtpBatchReadResult.Version` returns the controller firmware version from the response.

## File access and decoding via CGTP

- New `CgtpFileClient` accessible via `CgtpClient.Http`: download and decode controller files over HTTP, without FTP.
- `CgtpClient.Http` inherits from `FileClientBase`: all shared file-reading methods are available (`GetSummaryDiagnostic()`, `GetAllErrorsList()`, `GetCurrentPosition()`, `GetIOState()`, `GetSafetyStatus()`, `GetProgramStates()`, `GetVariablesFromFile()`, `KnownVariableFiles`).
- `BasePath` property (default `"MD"`) controls the root path used for file downloads.
- `DownloadAsBytes(fileName)`, `DownloadAsString(fileName)`, and `DownloadAsStream(fileName)` to download raw files from the controller. HTML responses containing a `<PRE>` block are automatically unwrapped; binary files are returned as-is.
- `ListVariables()` returns `CgtpAsciiFileItem[]` listing all variable files (binary and ASCII) from the controller.
- `ListTpPrograms()` returns `CgtpAsciiFileItem[]` listing all TP program files (binary and ASCII) from the controller.
- `ListDiagnosticFiles()` returns `CgtpFileItem[]` listing all diagnostic and error log files from the controller.
- `ListOtherFiles()` returns `CgtpFileItem[]` listing all other files from the controller.
- New data models: `CgtpFileItem` (with `File` and `Comment` properties) and `CgtpAsciiFileItem` (adds `AsciiFile` for the ASCII format variant).

## Handle comments and user alarms via CGTP

- Bulk read of numeric registers with comments and values via `ReadNumericRegistersWithComment()`.
- Bulk read of string registers with comments and values via `ReadStringRegistersWithComment()`.
- Bulk read of user alarm definitions (comment and severity) via `ReadUserAlarms()`.
- New unified `GetComments(CgtpCommentType type)` method to read all comments for any element type: numeric registers, position registers, string registers, user alarms, flags, and all I/O types (DI, DO, RI, RO, GI, GO, AI, AO).
- New `GetIoComments(CgtpCommentIoType type)` method to read paired input/output comments for a given I/O type (Robot, Digital, Group, Analog).
- `SetComment(CgtpCommentType type, int index, string comment)` to write the comment of any register or I/O port.
- `WriteNumericRegisterAsDouble()` and `WriteNumericRegisterAsInteger()` to write numeric register values with explicit type control.
- `WriteStringRegister()` to write a string register value.
- `SetUserAlarmSeverity()` to set the severity level of a user alarm.
- New enums `CgtpCommentType` and `CgtpCommentIoType` for strongly-typed comment operations.
- New data models: `StringRegisterWithComment`, `UserAlarmDefinition`, `IOComments`.
- HTTP Basic authentication support: new `Login` and `Password` properties on `CgtpConnectParametersBase` for controllers that require credentials.
- CGTP also works on the standard HTTP port 80 by setting `CgtpConnectParameters.Port = 80`.

## New KCL client over CGTP

- New `CgtpKclClient` class accessible via `CgtpClient.Kcl` : execute KCL commands over the CGTP Web Server (HTTP), without a Telnet connection.
- Full KCL command set available: `Abort`, `AbortAll`, `ClearAll`, `ClearProgram`, `ClearVars`, `Continue`, `Hold`, `Pause`, `Reset`, `Run`, `SetPort`, `SetVariable`, `GetCurrentPose`, `GetVariable`, `Simulate`, `Unsimulate`, `UnsimulateAll`, `SendCustomCommand`, `GetTaskInformation`, `AddBreakpoint`, `RemoveBreakpoint`, `RemoveAllBreakpoints`, `GetBreakpoints`, `StepOn`, `StepOff`.
- New `SendCustomCommandUnsafe()` method to send any custom KCL command via the Comet CPKCL endpoint.
- New abstract `KclClientBase` base class in `UnderAutomation.Fanuc.Common.Kcl` shared between `TelnetClientBase` and `CgtpKclClient`, ensuring a unified KCL API across both protocols.
- `CgtpClient.Kcl` is never null and always uses the language configured on `CgtpClient`.

## New Telnet Feature

- New event `StringDataReceived` on `TelnetClientBase` to receive decoded string data from the controller, in addition to raw byte data. This is useful for handling text-based responses from any connected KCL client (CGTP, Telnet, ...) in a unified way.

## Shared file reading foundation (FTP)

- File reading, parsing, and variable decoding logic has been extracted from the FTP client into a shared foundation in `UnderAutomation.Fanuc.Common.Files`, laying the groundwork for future protocol-agnostic file access.
- New `FileClientBase` abstract base class in `UnderAutomation.Fanuc.Common.Files`: centralizes methods such as `GetSummaryDiagnostic()`, `GetAllErrorsList()`, `GetCurrentPosition()`, `GetIOState()`, `GetSafetyStatus()`, `GetProgramStates()`, `GetVariablesFromFile()`, and the `KnownVariableFiles` property.
- `FtpClientBase` now inherits from `FileClientBase`: all file-reading methods remain available on the FTP client with the same signatures.
- `FtpKnownVariableFiles` has been replaced by the shared `KnownVariableFiles` class in `UnderAutomation.Fanuc.Common.Files`.
- `FanucFileReaders` static helper (reading `.va`, `.dg`, `.ls` files) moved to `UnderAutomation.Fanuc.Common.Files`.
- New `FanucFileReaders.ReadFile(string path)` static method to read and auto-detect any supported Fanuc file from disk.
- New `ParseResult()` method in KCL `GetVariableResult` class to decode and get a structured representation of the variable (value, type, scope, ...).

## Breaking changes

- **`CgtpClient.Connect()` signature changed**: now accepts optional `login` and `password` parameters.
- Namespace migration for shared KCL types: `Result`, `BaseResult`, `KCLPorts`, `KclClientBase`, and all KCL result classes (`ProgramCommandResult`, `RunResult`, `SetVariableResult`, `GetVariableResult`, `SetPortResult`, `SimulateResult`, `UnsimulateResult`, `GetCurrentPoseResult`, `TaskInformationResult`, `BreakpointsResult`, etc.) moved from `UnderAutomation.Fanuc.Telnet` to `UnderAutomation.Fanuc.Common.Kcl`.
- Telnet-specific event types (`RawDataReceivedEventArgs`, `TpCoordinates`, `MessageReceivedEventArgs`, `KclClientErrorEventArgs`, `CommandSentEventArgs`, `KclCommandReceived`) remain in `UnderAutomation.Fanuc.Telnet`.
- Namespace migration for shared position models: moved from `UnderAutomation.Fanuc.Ftp.Variables` to `UnderAutomation.Fanuc.Common`.
- Affected types: `CartesianPositionVariable`, `JointPositionVariable`, `PositionRegister`, `VectorVariable`.
- Namespace migration for file reading and variable decoding:
  - Diagnosis types (`SummaryDiagnosis`, `CurrentPosition`, `IOState`, `SafetyStatus`, `ProgramStates`, `GroupPosition`, `Feature`, etc.) moved from `UnderAutomation.Fanuc.Ftp.Diagnosis` to `UnderAutomation.Fanuc.Common.Files.Diagnosis`.
  - Error list types (`ErrorList`, `ErrallSectionItem`, `ErrallSectionParser`) moved from `UnderAutomation.Fanuc.Ftp.Files.List` to `UnderAutomation.Fanuc.Common.Files.List`.
  - Variable types (`GenericVariableFile`, `GenericVariable`, `GenericField`, `GenericValue`, `ValueKind`, `ArrayElement`, `VariableFile`, `VariableFileList`, etc.) moved from `UnderAutomation.Fanuc.Ftp.Variables` to `UnderAutomation.Fanuc.Common.Files.Variables`.
  - All autogenerated variable file readers and type definitions moved from `UnderAutomation.Fanuc.Ftp.Autogenerated` to `UnderAutomation.Fanuc.Common.Files.Variables.Autogenerated`.
  - File infrastructure types (`FanucFileReaders`, `FileParser`, `FileReader`, `IFileReader`, `IFanucContent`) moved from `UnderAutomation.Fanuc.Ftp` / `UnderAutomation.Fanuc.Ftp.Internal` to `UnderAutomation.Fanuc.Common.Files`.
- `TelnetClientBase` now inherits from `KclClientBase` : all KCL methods remain available on the Telnet client with the same signatures.
- CGTP enum/type naming has been aligned for clarity in public APIs (for example IoPortType and ProgramSubType naming in CGTP).

## Improved

- Improved robustness of value parsing for position and register data.
- Improved CGTP error reporting with clearer messages in common failure scenarios.
