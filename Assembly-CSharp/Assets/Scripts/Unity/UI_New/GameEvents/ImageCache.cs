namespace Assets.Scripts.Unity.UI_New.GameEvents;

public class ImageCache
{
	[CompilerGenerated]
	private string <Etag>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <B64ImageData>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private DateTime <CreationTime>k__BackingField; //Field offset: 0x20

	public string B64ImageData
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime CreationTime
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public string Etag
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[JsonIgnore]
	public Byte[] ImageData
	{
		 get { } //Length: 100
		 set { } //Length: 116
	}

	public ImageCache() { }

	[CompilerGenerated]
	public string get_B64ImageData() { }

	[CompilerGenerated]
	public DateTime get_CreationTime() { }

	[CompilerGenerated]
	public string get_Etag() { }

	public Byte[] get_ImageData() { }

	[CompilerGenerated]
	public void set_B64ImageData(string value) { }

	[CompilerGenerated]
	public void set_CreationTime(DateTime value) { }

	[CompilerGenerated]
	public void set_Etag(string value) { }

	public void set_ImageData(Byte[] value) { }

}

