//Type is in global namespace

public struct UniWebViewMessage
{
	[CompilerGenerated]
	private string <RawMessage>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private string <Scheme>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private string <Path>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Dictionary<String, String> <Args>k__BackingField; //Field offset: 0x18

	public private Dictionary<String, String> Args
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private string Path
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private string RawMessage
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private string Scheme
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 291
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public UniWebViewMessage(string rawMessage) { }

	[CompilerGenerated]
	[IsReadOnly]
	public Dictionary<String, String> get_Args() { }

	[CompilerGenerated]
	[IsReadOnly]
	public string get_Path() { }

	[CompilerGenerated]
	[IsReadOnly]
	public string get_RawMessage() { }

	[CompilerGenerated]
	[IsReadOnly]
	public string get_Scheme() { }

	[CompilerGenerated]
	private void set_Args(Dictionary<String, String> value) { }

	[CompilerGenerated]
	private void set_Path(string value) { }

	[CompilerGenerated]
	private void set_RawMessage(string value) { }

	[CompilerGenerated]
	private void set_Scheme(string value) { }

}

