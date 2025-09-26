- Telnet : add capability to send a custom KCL command

```cs
robot.Telnet.SendCustomCommand("My KCL Command");
```

- SNPX : Add active alarm and alarm history access

```cs
RobotAlarm firstActiveAlarm = robot.Snpx.ActiveAlarm.Read(1);
RobotAlarm secondAlarmInHistory = robot.Snpx.AlarmHistory.Read(1);
```
