namespace NinjaKiwi.LiNK.Client.Files;

public class File
{
	public T content; //Field offset: 0x0
	public readonly string name; //Field offset: 0x0
	[CompilerGenerated]
	private int <SaveCount>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Nullable<Guid> <Guid>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Nullable<DateTime> <DateCreated>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Nullable<DateTime> <DateModified>k__BackingField; //Field offset: 0x0
	private readonly PasswordGenerator passwordGenerator; //Field offset: 0x0
	private readonly JsonSerializerSettings jsonSettings; //Field offset: 0x0
	private readonly IStorage storage; //Field offset: 0x0

	public Nullable<DateTime> DateCreated
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Nullable<DateTime> DateModified
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Nullable<Guid> Guid
	{
		[CompilerGenerated]
		 get { } //Length: 17
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public bool IsLocalFile
	{
		 get { } //Length: 130
	}

	public int SaveCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	internal File`1(T content, PasswordGenerator passwordGenerator, JsonSerializerSettings jsonSettings, IStorage storage, int saveCount, Nullable<Guid> guid, Nullable<DateTime> dateCreated, Nullable<DateTime> dateModified) { }

	public T DecodeContent(string base64) { }

	[CompilerGenerated]
	public Nullable<DateTime> get_DateCreated() { }

	[CompilerGenerated]
	public Nullable<DateTime> get_DateModified() { }

	[CompilerGenerated]
	public Nullable<Guid> get_Guid() { }

	public bool get_IsLocalFile() { }

	[CompilerGenerated]
	public int get_SaveCount() { }

	public string GetBinary() { }

	public void ReadFrom(File<T> source) { }

	public void ReloadFromBinary(string base64) { }

	public void Save() { }

	[CompilerGenerated]
	protected void set_DateCreated(Nullable<DateTime> value) { }

	[CompilerGenerated]
	protected void set_DateModified(Nullable<DateTime> value) { }

	[CompilerGenerated]
	protected void set_Guid(Nullable<Guid> value) { }

	[CompilerGenerated]
	protected void set_SaveCount(int value) { }

	public void SetContentAndSave(T newContent) { }

	[Conditional("UNITY_EDITOR")]
	public void SetGuid(Guid value) { }

	public bool TryGetLocalFilePath(out string localFilePath) { }

	private void UpdateStateForSave() { }

	public void Wipe() { }

}

