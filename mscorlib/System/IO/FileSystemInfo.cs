namespace System.IO;

public abstract class FileSystemInfo : MarshalByRefObject, ISerializable
{
	private WIN32_FILE_ATTRIBUTE_DATA _data; //Field offset: 0x18
	private int _dataInitialized; //Field offset: 0x3C
	protected string FullPath; //Field offset: 0x40
	protected string OriginalPath; //Field offset: 0x48
	internal string _name; //Field offset: 0x50

	public FileAttributes Attributes
	{
		 get { } //Length: 109
	}

	internal DateTimeOffset CreationTimeCore
	{
		internal get { } //Length: 141
	}

	public DateTime CreationTimeUtc
	{
		 get { } //Length: 194
	}

	public override bool Exists
	{
		 get { } //Length: 133
	}

	internal bool ExistsCore
	{
		internal get { } //Length: 133
	}

	public string Extension
	{
		 get { } //Length: 282
	}

	public override string FullName
	{
		 get { } //Length: 5
	}

	public DateTime LastWriteTime
	{
		 get { } //Length: 260
	}

	internal DateTimeOffset LastWriteTimeCore
	{
		internal get { } //Length: 141
	}

	public DateTime LastWriteTimeUtc
	{
		 get { } //Length: 194
	}

	internal long LengthCore
	{
		internal get { } //Length: 119
	}

	public override string Name
	{
		 get { } //Length: 5
	}

	internal string NormalizedPath
	{
		internal get { } //Length: 181
	}

	protected FileSystemInfo() { }

	protected FileSystemInfo(SerializationInfo info, StreamingContext context) { }

	internal static FileSystemInfo Create(string fullPath, ref FileSystemEntry findData) { }

	public abstract void Delete() { }

	private void EnsureDataInitialized() { }

	public FileAttributes get_Attributes() { }

	internal DateTimeOffset get_CreationTimeCore() { }

	public DateTime get_CreationTimeUtc() { }

	public override bool get_Exists() { }

	internal bool get_ExistsCore() { }

	public string get_Extension() { }

	public override string get_FullName() { }

	public DateTime get_LastWriteTime() { }

	internal DateTimeOffset get_LastWriteTimeCore() { }

	public DateTime get_LastWriteTimeUtc() { }

	internal long get_LengthCore() { }

	public override string get_Name() { }

	internal string get_NormalizedPath() { }

	[ComVisible(False)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal void Init(FILE_FULL_DIR_INFORMATION* info) { }

	public void Refresh() { }

	public virtual string ToString() { }

}

