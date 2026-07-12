using System.Linq;
using System.Xml.Serialization;
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.Common;
using UnderAutomation.Fanuc.Rmi.TpInstructions;

// Save user information in a file next to the main executable
public class Config
{
    // Configuration instance
    public static Config Current { get; private set; } = new Config();

    private static XmlSerializer CreateSerializer()
    {
        // Discover all concrete RmiInstructionBase subtypes from the SDK assembly at runtime,
        // so no manual update is needed when new instruction types are added.
        var knownTypes = typeof(RmiInstructionBase).Assembly
            .GetTypes()
            .Where(t => !t.IsAbstract && typeof(RmiInstructionBase).IsAssignableFrom(t))
            .ToArray();

        // JointsPosition.Values has a private setter — XmlSerializer cannot deserialize it.
        // J1-J9 have public setters and carry the same data, so ignoring Values is safe.
        var overrides = new XmlAttributeOverrides();
        overrides.Add(typeof(JointsPosition), "Values", new XmlAttributes { XmlIgnore = true });

        return new XmlSerializer(typeof(Config), overrides, knownTypes, null, null);
    }

    // Serializer for configuration 
    private static readonly XmlSerializer _serializer = CreateSerializer();

    // Configuration file
    private static string Path => $"{Environment.ProcessPath}.xml";

    // Serialize configuration file
    public static void Save()
    {
        try
        {
            using (var writer = new StreamWriter(Path))
            {
                _serializer.Serialize(writer, Current);
            }
        }
        catch { }
    }

    // Deserialize configuration file
    public static void Load()
    {
        try
        {
            if (!File.Exists(Path)) return;

            using (var writer = new StreamReader(Path))
            {
                Current = (Config)_serializer.Deserialize(writer);
            }
        }
        catch { }
    }

    public ConnectionParameters ConnectParameters { get; set; } = new ConnectionParameters();

    public string[] CheckedVariableFiles { get; set; }

    #region HMI Properties
    public string Licensee { get; set; }
    public string Key { get; set; }
    public string FtpPath { get; set; }
    public RmiState RmiState { get; set; }
    #endregion
}

