namespace Unity.Services.Analytics.Data;

internal class StdCommonParams
{
	[CompilerGenerated]
	private string <GameStoreID>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <GameBundleID>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <Platform>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <UasUserID>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private string <Idfv>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private Nullable<Double> <DeviceVolume>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private Nullable<Double> <BatteryLoad>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private string <BuildGuuid>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private string <ClientVersion>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private string <UserCountry>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private string <ProjectID>k__BackingField; //Field offset: 0x70

	internal Nullable<Double> BatteryLoad
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	internal string BuildGuuid
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 5
	}

	internal string ClientVersion
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 5
	}

	internal Nullable<Double> DeviceVolume
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	internal string GameBundleID
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 5
	}

	internal string GameStoreID
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	internal string Idfv
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 5
	}

	internal string Platform
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 5
	}

	internal string ProjectID
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 5
	}

	internal string UasUserID
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 5
	}

	internal string UserCountry
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	public StdCommonParams() { }

	[CompilerGenerated]
	internal Nullable<Double> get_BatteryLoad() { }

	[CompilerGenerated]
	internal string get_BuildGuuid() { }

	[CompilerGenerated]
	internal string get_ClientVersion() { }

	[CompilerGenerated]
	internal Nullable<Double> get_DeviceVolume() { }

	[CompilerGenerated]
	internal string get_GameBundleID() { }

	[CompilerGenerated]
	internal string get_GameStoreID() { }

	[CompilerGenerated]
	internal string get_Idfv() { }

	[CompilerGenerated]
	internal string get_Platform() { }

	[CompilerGenerated]
	internal string get_ProjectID() { }

	[CompilerGenerated]
	internal string get_UasUserID() { }

	[CompilerGenerated]
	internal string get_UserCountry() { }

	internal void SerializeCommonEventParams(ref IBuffer buf, string callingMethodIdentifier) { }

	[CompilerGenerated]
	internal void set_BatteryLoad(Nullable<Double> value) { }

	[CompilerGenerated]
	internal void set_BuildGuuid(string value) { }

	[CompilerGenerated]
	internal void set_ClientVersion(string value) { }

	[CompilerGenerated]
	internal void set_DeviceVolume(Nullable<Double> value) { }

	[CompilerGenerated]
	internal void set_GameBundleID(string value) { }

	[CompilerGenerated]
	internal void set_Idfv(string value) { }

	[CompilerGenerated]
	internal void set_Platform(string value) { }

	[CompilerGenerated]
	internal void set_ProjectID(string value) { }

	[CompilerGenerated]
	internal void set_UasUserID(string value) { }

}

