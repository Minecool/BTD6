namespace NinjaKiwi.GUTS.Models.Endpoints;

[Nullable(0)]
[NullableContext(2)]
public class SweepstakesStatusResponse : EndpointResponseBase, IEndpointResponse
{
	[JsonIgnore]
	public const char CsvSeparator = '\u2C'; //Field offset: 0x0
	[CompilerGenerated]
	private int <TotalTickets>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <ClaimedCsv>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <ShareCode>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private bool <WasShareSeen>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private bool <HasOpenedReferral>k__BackingField; //Field offset: 0x31
	[CompilerGenerated]
	private int <UnlockedTaskIndex>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private Nullable<DateTime> <NextTaskUnlockTime>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private bool <HasShared>k__BackingField; //Field offset: 0x48
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private String[] cachedClaimedTickets; //Field offset: 0x50

	public string ClaimedCsv
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public bool HasOpenedReferral
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool HasShared
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public Nullable<DateTime> NextTaskUnlockTime
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public string ShareCode
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[JsonIgnore]
	public override bool Success
	{
		 get { } //Length: 9
	}

	public int TotalTickets
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int UnlockedTaskIndex
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool WasShareSeen
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public SweepstakesStatusResponse() { }

	[CompilerGenerated]
	public string get_ClaimedCsv() { }

	[CompilerGenerated]
	public bool get_HasOpenedReferral() { }

	[CompilerGenerated]
	public bool get_HasShared() { }

	[CompilerGenerated]
	public Nullable<DateTime> get_NextTaskUnlockTime() { }

	[CompilerGenerated]
	public string get_ShareCode() { }

	public override bool get_Success() { }

	[CompilerGenerated]
	public int get_TotalTickets() { }

	[CompilerGenerated]
	public int get_UnlockedTaskIndex() { }

	[CompilerGenerated]
	public bool get_WasShareSeen() { }

	[NullableContext(1)]
	public static string GetClaimTaskStepKey(int taskIndex, int taskStepIndex) { }

	public bool HasClaimed(int taskIndex, int taskStepIndex) { }

	[CompilerGenerated]
	public void set_ClaimedCsv(string value) { }

	[CompilerGenerated]
	public void set_HasOpenedReferral(bool value) { }

	[CompilerGenerated]
	public void set_HasShared(bool value) { }

	[CompilerGenerated]
	public void set_NextTaskUnlockTime(Nullable<DateTime> value) { }

	[CompilerGenerated]
	public void set_ShareCode(string value) { }

	[CompilerGenerated]
	public void set_TotalTickets(int value) { }

	[CompilerGenerated]
	public void set_UnlockedTaskIndex(int value) { }

	[CompilerGenerated]
	public void set_WasShareSeen(bool value) { }

}

