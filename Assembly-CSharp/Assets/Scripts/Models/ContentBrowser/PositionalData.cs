namespace Assets.Scripts.Models.ContentBrowser;

public class PositionalData
{
	[JsonConverter(typeof(Vector3ConverterSmall))]
	public Vector3 position; //Field offset: 0x10
	[JsonConverter(typeof(Vector3ConverterSmall))]
	public Vector3 rotation; //Field offset: 0x1C
	public float scale; //Field offset: 0x28
	public float heightOffset; //Field offset: 0x2C

	public PositionalData() { }

	public PositionalData Clone() { }

	public bool Compare(PositionalData com) { }

}

