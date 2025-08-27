namespace Assets.Scripts.Unity.Analytics;

public class ContentBrowserAnalytics
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<TowerData, Boolean> <>9__8_0; //Field offset: 0x8
		public static Func<TowerData, String> <>9__8_1; //Field offset: 0x10
		public static Func<TowerData, Boolean> <>9__8_2; //Field offset: 0x18
		public static Func<TowerData, String> <>9__8_3; //Field offset: 0x20
		public static Func<TowerData, Boolean> <>9__8_4; //Field offset: 0x28
		public static Func<TowerData, String> <>9__8_5; //Field offset: 0x30
		public static Func<TowerData, Boolean> <>9__8_6; //Field offset: 0x38
		public static Func<TowerData, String> <>9__8_7; //Field offset: 0x40
		public static Func<KeyValuePair`2<OdysseyDifficulty, Rules>, Boolean> <>9__11_0; //Field offset: 0x48
		public static Func<TowerData, Boolean> <>9__11_1; //Field offset: 0x50
		public static Func<TowerData, String> <>9__11_2; //Field offset: 0x58
		public static Func<TowerData, Boolean> <>9__11_3; //Field offset: 0x60
		public static Func<TowerData, String> <>9__11_4; //Field offset: 0x68
		public static Func<TowerData, Boolean> <>9__11_5; //Field offset: 0x70
		public static Func<TowerData, String> <>9__11_6; //Field offset: 0x78
		public static Func<TowerData, Boolean> <>9__11_7; //Field offset: 0x80
		public static Func<TowerData, String> <>9__11_8; //Field offset: 0x88
		public static Func<PowerData, Boolean> <>9__11_9; //Field offset: 0x90
		public static Func<PowerData, String> <>9__11_10; //Field offset: 0x98
		public static Func<PowerData, Boolean> <>9__11_11; //Field offset: 0xA0
		public static Func<PowerData, String> <>9__11_12; //Field offset: 0xA8
		public static Func<DefaultData, Boolean> <>9__11_13; //Field offset: 0xB0
		public static Func<DefaultData, String> <>9__11_14; //Field offset: 0xB8
		public static Func<DefaultData, Boolean> <>9__11_15; //Field offset: 0xC0
		public static Func<DefaultData, String> <>9__11_16; //Field offset: 0xC8

		private static <>c() { }

		public <>c() { }

		internal bool <OdysseySubmitted>b__11_0(KeyValuePair<OdysseyDifficulty, Rules> x) { }

		internal bool <OdysseySubmitted>b__11_1(TowerData t) { }

		internal string <OdysseySubmitted>b__11_10(PowerData x) { }

		internal bool <OdysseySubmitted>b__11_11(PowerData p) { }

		internal string <OdysseySubmitted>b__11_12(PowerData x) { }

		internal bool <OdysseySubmitted>b__11_13(DefaultData x) { }

		internal string <OdysseySubmitted>b__11_14(DefaultData x) { }

		internal bool <OdysseySubmitted>b__11_15(DefaultData x) { }

		internal string <OdysseySubmitted>b__11_16(DefaultData x) { }

		internal string <OdysseySubmitted>b__11_2(TowerData x) { }

		internal bool <OdysseySubmitted>b__11_3(TowerData t) { }

		internal string <OdysseySubmitted>b__11_4(TowerData x) { }

		internal bool <OdysseySubmitted>b__11_5(TowerData t) { }

		internal string <OdysseySubmitted>b__11_6(TowerData x) { }

		internal bool <OdysseySubmitted>b__11_7(TowerData t) { }

		internal string <OdysseySubmitted>b__11_8(TowerData t) { }

		internal bool <OdysseySubmitted>b__11_9(PowerData p) { }

		internal bool <SubmittedChallenge>b__8_0(TowerData t) { }

		internal string <SubmittedChallenge>b__8_1(TowerData t) { }

		internal bool <SubmittedChallenge>b__8_2(TowerData t) { }

		internal string <SubmittedChallenge>b__8_3(TowerData x) { }

		internal bool <SubmittedChallenge>b__8_4(TowerData t) { }

		internal string <SubmittedChallenge>b__8_5(TowerData x) { }

		internal bool <SubmittedChallenge>b__8_6(TowerData t) { }

		internal string <SubmittedChallenge>b__8_7(TowerData x) { }

	}

	private readonly AnalyticsManager analyticsManager; //Field offset: 0x10

	public ContentBrowserAnalytics(AnalyticsManager analyticsManager) { }

	public void Deleted(ContentType contentType, string id) { }

	public void DropdownChanged(ContentType contentType, SelectionType oldSelection, SelectionType newSelection) { }

	public void Favorited(ContentType contentType, string id, bool isAdd) { }

	public void FeaturedContentStarted(string contentType, string contentId, bool isRestart) { }

	public void Liked(ContentType contentType, string id) { }

	public void OdysseyDcm(string id, DailyChallengeModel dcm, int islandNumber) { }

	public void OdysseySubmitted(string id, OdysseyData odysseyData) { }

	public void Open(string from) { }

	private void Report(AnalyticsData data) { }

	public void SubmittedChallenge(string id, DailyChallengeModel dcm) { }

	public void SubmittedGame(string id, GameEditorModel gameEditorModel, string creationId) { }

	public void SubmittedMap(string id, MapEditorModel mapEditorModel, string creationId) { }

	public void TabChanged(ContentType from, ContentType to) { }

}

