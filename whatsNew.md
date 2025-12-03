# Major new feature

Added **forward and inverse kinematics** support for CRX cobots and other Fanuc robots with a traditional spherical wrist.

```csharp
using UnderAutomation.Fanuc.Kinematics;

JointsPosition position = new JointsPosition(10, 20, 120, 0, 0, 25);

// ---- Get DH parameters ----
// Example: CRX-10iA/L
DhParameters dh = new DhParameters(-540, 150, -160, 0, 710, 0);

// From a known arm model
dh = DhParameters.FromArmKinematicModel(ArmKinematicModels.CRX10iA);

// From OPW parameters: M10iA/7L
dh = DhParameters.FromOpwParameters(0.15, -0.20, 0.60, 0.86, 0.10);

// From an online robot (SYSMOTN file)
dh = DhParameters.FromSymotnFile(_robot.Ftp.KnownVariableFiles.GetSymotnFile())[0];

// ---- Forward kinematics ----
CartesianPosition pose = KinematicsUtils.ForwardKinematics(position, dh);

// ---- Inverse kinematics with multiple solutions ----
JointsPosition[] positions = KinematicsUtils.InverseKinematics(pose, dh);
```

# Minor fixes

- SNPX: Fixed writing of position registers and position variables where the configuration was always written with the default value.
- SNPX: Fixed reading of position register configuration so that it uses the correct Turn4 to Turn6 values.
- Removed properties `T4`, `T5`, `T6` from `UnderAutomation.Fanuc.Common.ExtendedCartesianPosition`. This information is now available in the `Configuration` property.
- Renamed and fixed properties `Turn1`, `Turn2`, `Turn3` to `Turn4`, `Turn5`, `Turn6` in `UnderAutomation.Fanuc.Common.Configuration` so they match the correct axes.
- Allowed connection to ROBOGUIDE by setting both the robot folder path and the path to the `services.txt` file.
