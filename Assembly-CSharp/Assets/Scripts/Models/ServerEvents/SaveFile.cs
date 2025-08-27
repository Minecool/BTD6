namespace Assets.Scripts.Models.ServerEvents;

public class SaveFile
{
	public bool ignoreCorrupted; //Field offset: 0x10
	[JsonConverter(typeof(VersionConverter))]
	[JsonProperty("latestCompatible")]
	public Version latestCompatibleVersion; //Field offset: 0x18

	public SaveFile() { }

}

