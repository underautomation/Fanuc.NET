- Add `GetEncoding` method to `StringUtils` for retrieving encoding by controller language

```csharp
namespace UnderAutomation.Fanuc.Common;

public static class StringUtils {
    public static Encoding GetEncoding(Languages language);
}
```

- Fix Telnet program Breakpoint commands for Japanese and Chinese controllers

- Set FTP encoding according to robot controller language
