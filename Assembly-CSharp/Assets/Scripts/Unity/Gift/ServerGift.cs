namespace Assets.Scripts.Unity.Gift;

public class ServerGift : ILocalisedGift
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<GiftCurrency, Boolean> <>9__17_0; //Field offset: 0x8
		public static Func<GiftCurrency, Boolean> <>9__17_1; //Field offset: 0x10
		public static Func<GiftCurrency, Boolean> <>9__17_2; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <FindGiftType>b__17_0(GiftCurrency x) { }

		internal bool <FindGiftType>b__17_1(GiftCurrency x) { }

		internal bool <FindGiftType>b__17_2(GiftCurrency x) { }

	}

	[CompilerGenerated]
	private GiftCurrency[] <Currencies>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Dictionary<String, String> <LocalisedMessages>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private DateTime <ReceivedTime>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private GiftType <GiftType>k__BackingField; //Field offset: 0x28

	public GiftCurrency[] Currencies
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public override GiftType GiftType
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override Dictionary<String, String> LocalisedMessages
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime ReceivedTime
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public ServerGift() { }

	private static GiftType FindGiftType(GiftCurrency[] giftCurrencies) { }

	[CompilerGenerated]
	public GiftCurrency[] get_Currencies() { }

	[CompilerGenerated]
	public override GiftType get_GiftType() { }

	[CompilerGenerated]
	public override Dictionary<String, String> get_LocalisedMessages() { }

	[CompilerGenerated]
	public DateTime get_ReceivedTime() { }

	[CompilerGenerated]
	public void set_Currencies(GiftCurrency[] value) { }

	[CompilerGenerated]
	public void set_GiftType(GiftType value) { }

	[CompilerGenerated]
	public void set_LocalisedMessages(Dictionary<String, String> value) { }

	[CompilerGenerated]
	public void set_ReceivedTime(DateTime value) { }

	[OnDeserialized]
	private void Validate(StreamingContext context = null) { }

}

