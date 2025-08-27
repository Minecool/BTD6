namespace NinjaKiwi.GUTS.Models.Sweepstakes;

[Nullable(0)]
[NullableContext(2)]
public class SweepstakesWinnerMessage
{
	[JsonIgnore]
	public const int PubSubMessageType = 6676; //Field offset: 0x0
	[JsonIgnore]
	[Nullable(1)]
	public const string ChannelName = "sweepstakes"; //Field offset: 0x0
	[CompilerGenerated]
	private string <ClaimCode>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <EventId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <ClaimUrl>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <PrizeImage>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private DateTime <SentTime>k__BackingField; //Field offset: 0x30

	public string ClaimCode
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public string ClaimUrl
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public string EventId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public string PrizeImage
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public DateTime SentTime
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public SweepstakesWinnerMessage() { }

	[CompilerGenerated]
	public string get_ClaimCode() { }

	[CompilerGenerated]
	public string get_ClaimUrl() { }

	[CompilerGenerated]
	public string get_EventId() { }

	[CompilerGenerated]
	public string get_PrizeImage() { }

	[CompilerGenerated]
	public DateTime get_SentTime() { }

	[CompilerGenerated]
	public void set_ClaimCode(string value) { }

	[CompilerGenerated]
	public void set_ClaimUrl(string value) { }

	[CompilerGenerated]
	public void set_EventId(string value) { }

	[CompilerGenerated]
	public void set_PrizeImage(string value) { }

	[CompilerGenerated]
	public void set_SentTime(DateTime value) { }

}

