namespace Assets.Scripts.Unity.UI_New.Popups;

public class GiftEventPopup : Popup
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<BaseLoot, Boolean> <>9__7_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <Load>b__7_0(BaseLoot x) { }

	}

	[SerializeField]
	private Image mrBeastImage; //Field offset: 0x128
	private GiftEvent giftEvent; //Field offset: 0x130
	private LootSet giftLoot; //Field offset: 0x138
	[CompilerGenerated]
	private bool <HasValidLoot>k__BackingField; //Field offset: 0x140

	public private bool HasValidLoot
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public GiftEventPopup() { }

	public void ClaimGift() { }

	[CompilerGenerated]
	public bool get_HasValidLoot() { }

	private static string GetBodyLocKey(GiftEventType giftEventType) { }

	private static string GetTitleLocKey(GiftEventType giftEventType) { }

	public void Load(GiftEvent giftEvent) { }

	[CompilerGenerated]
	private void set_HasValidLoot(bool value) { }

	private static bool TryParseCsv(string csv, out HashSet<String>& csvItems) { }

	private static bool TryParsePowers(string powersCsv, out Dictionary<String, Int32>& powers) { }

}

