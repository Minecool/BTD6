namespace Facepunch.Steamworks;

public class Image
{
	[CompilerGenerated]
	private int <Id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <Width>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private int <Height>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Byte[] <Data>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <IsLoaded>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private bool <IsError>k__BackingField; //Field offset: 0x29

	public internal Byte[] Data
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 5
	}

	public internal int Height
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	public internal int Id
	{
		[CompilerGenerated]
		 get { } //Length: 94
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	internal bool IsError
	{
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	public internal bool IsLoaded
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	public internal int Width
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	public Image() { }

	[CompilerGenerated]
	public Byte[] get_Data() { }

	[CompilerGenerated]
	public int get_Height() { }

	[CompilerGenerated]
	public int get_Id() { }

	[CompilerGenerated]
	public bool get_IsLoaded() { }

	[CompilerGenerated]
	public int get_Width() { }

	public Color GetPixel(int x, int y) { }

	[CompilerGenerated]
	internal void set_Data(Byte[] value) { }

	[CompilerGenerated]
	internal void set_Height(int value) { }

	[CompilerGenerated]
	internal void set_Id(int value) { }

	[CompilerGenerated]
	internal void set_IsError(bool value) { }

	[CompilerGenerated]
	internal void set_IsLoaded(bool value) { }

	[CompilerGenerated]
	internal void set_Width(int value) { }

	internal bool TryLoad(SteamUtils utils) { }

}

