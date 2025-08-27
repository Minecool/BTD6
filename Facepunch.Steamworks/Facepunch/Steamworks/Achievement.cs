namespace Facepunch.Steamworks;

public class Achievement
{
	private Client client; //Field offset: 0x10
	[CompilerGenerated]
	private string <Id>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <Description>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private bool <State>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private DateTime <UnlockTime>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private int <iconId>k__BackingField; //Field offset: 0x40
	private int refreshCount; //Field offset: 0x44
	private Image _icon; //Field offset: 0x48

	private string Description
	{
		[CompilerGenerated]
		private set { } //Length: 5
	}

	private int iconId
	{
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private string Id
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	private string Name
	{
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private bool State
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 86
	}

	private DateTime UnlockTime
	{
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public Achievement(Client client, int index) { }

	[CompilerGenerated]
	public string get_Id() { }

	[CompilerGenerated]
	public bool get_State() { }

	public bool Refresh() { }

	[CompilerGenerated]
	private void set_Description(string value) { }

	[CompilerGenerated]
	private void set_iconId(int value) { }

	[CompilerGenerated]
	private void set_Id(string value) { }

	[CompilerGenerated]
	private void set_Name(string value) { }

	[CompilerGenerated]
	private void set_State(bool value) { }

	[CompilerGenerated]
	private void set_UnlockTime(DateTime value) { }

	public bool Trigger(bool apply = true) { }

}

