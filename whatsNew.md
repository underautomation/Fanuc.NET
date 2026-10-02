## Asynchronous FTP methods

Every blocking FTP method has an asynchronous version with an optional `CancellationToken`: `robot.Ftp.DirectFileHandling` (upload, download, listing, files and folders), `FtpClient.ConnectAsync`, `EnumerateVariableFilesAsync`, and the reading of the decoded files (`GetSummaryDiagnosticAsync`, `GetAllVariablesAsync`, `KnownVariableFiles.Get...Async`...), also on `robot.Cgtp.Http`. They are not available on .NET Framework 3.5 and 4.0. The synchronous and asynchronous methods of one client can be called from several threads: they run one at a time.

```csharp
byte[] program = await robot.Ftp.DirectFileHandling.DownloadBytesFromControllerAsync("md:/MyPrg.ls");
await robot.Ftp.DirectFileHandling.UploadFileToControllerAsync(program, "md:/MyPrg.ls", cancellationToken: token);
NumregFile numreg = await robot.Ftp.KnownVariableFiles.GetNumregFileAsync();
```

## FTP errors

When the controller refuses an FTP operation, the SDK throws an `FtpException` with the reply of the controller (`ReplyCode`, `ReplyMessage`) and what to do. `ProgramInUse` is true when the program is selected or runs ("Specified program is in use"): select another program on the teach pendant, or with `robot.Cgtp.SelectProgram(...)` (firmware V9.10 and later). Without an FTP user, the controller logs in at the OPERATOR level and can refuse the upload of a program ("Operation password protected"): the message says to use a user of a higher level.

```csharp
try
{
    robot.Ftp.DirectFileHandling.UploadFileToController(@"C:\Programs\MyPrg.ls", "md:/MyPrg.ls");
}
catch (FtpException ex) when (ex.ProgramInUse)
{
    robot.Cgtp.SelectProgram("OTHER");
}
```

`FtpException` derives from `Exception`: a `catch (Exception)` still catches these errors.

## FTP fixes

- The FTP client was updated. It supports the asynchronous methods.
- Paths with a device (`fr:`, `md:job.ls`): `GetListing("fr:")` lists `fr:`, and no longer the current device. `FileExists` and `GetObjectInfo` find `md:job.ls`, `md:/job.ls` and `job.ls`, with any case.
- `GetObjectInfo` returns `null` for a missing file, as documented, instead of throwing a `NullReferenceException`.
- `GetSummaryDiagnostic`, `GetVariablesFromFile`, `KnownVariableFiles...` throw an `FtpException` when the download of the file fails, instead of returning an empty result.
- Setting `robot.Ftp.Language` changes the encoding of the connection at once. It used the previous language.
- `Disconnect` releases the connection, so that a new `Connect` does not leave the previous one open.
- `UploadFileToController` with `FtpExistsBehavior.Skip` or `Append` checks the existing file correctly on the devices of the controller.
- `robot.Cgtp.Http.DownloadAsBytes`: the controller can close the connection at the end of a binary file. The data received is now returned, as documented, instead of an error.
## Package information

The NuGet package links to the Fanuc page of underautomation.com, to the `Fanuc.NET` repository and to its release notes. Its description lists the supported protocols and controllers.
