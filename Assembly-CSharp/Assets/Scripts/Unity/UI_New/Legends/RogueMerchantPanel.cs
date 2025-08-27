namespace Assets.Scripts.Unity.UI_New.Legends;

public class RogueMerchantPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ArtifactLoot, Boolean> <>9__31_0; //Field offset: 0x8
		public static Func<RogueArtifactDisplayIcon, Boolean> <>9__38_0; //Field offset: 0x10
		public static Func<RogueArtifactDisplayIcon, Boolean> <>9__41_0; //Field offset: 0x18
		public static Func<RogueArtifactDisplayIcon, Boolean> <>9__41_1; //Field offset: 0x20
		public static Func<RogueArtifactDisplayIcon, Boolean> <>9__41_2; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal bool <AddMerchantIconToOffer>b__38_0(RogueArtifactDisplayIcon x) { }

		internal bool <Open>b__31_0(ArtifactLoot x) { }

		internal bool <RefreshUIs>b__41_0(RogueArtifactDisplayIcon x) { }

		internal bool <RefreshUIs>b__41_1(RogueArtifactDisplayIcon x) { }

		internal bool <RefreshUIs>b__41_2(RogueArtifactDisplayIcon x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass36_0
	{
		public RogueArtifactDisplayIcon artifactIcon; //Field offset: 0x10

		public <>c__DisplayClass36_0() { }

		internal bool <AddInventoryIconToOffer>b__0(RogueArtifactDisplayIcon x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass37_0
	{
		public RogueArtifactDisplayIcon artifactIcon; //Field offset: 0x10

		public <>c__DisplayClass37_0() { }

		internal bool <RemoveInventoryIconFromOffer>b__0(RogueArtifactDisplayIcon x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0
	{
		public RogueArtifactDisplayIcon artifactIcon; //Field offset: 0x10

		public <>c__DisplayClass38_0() { }

		internal bool <AddMerchantIconToOffer>b__1(RogueArtifactDisplayIcon x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass39_0
	{
		public RogueArtifactDisplayIcon artifactIcon; //Field offset: 0x10

		public <>c__DisplayClass39_0() { }

		internal bool <RemoveMerchantIconFromOffer>b__0(RogueArtifactDisplayIcon x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		public RogueArtifactDisplayIcon invArtifact; //Field offset: 0x10
		public Func<ArtifactLoot, Boolean> <>9__0; //Field offset: 0x18

		public <>c__DisplayClass44_0() { }

		internal bool <MakeTrade>b__0(ArtifactLoot x) { }

	}

	[SerializeField]
	private Button closeBtn; //Field offset: 0x20
	[SerializeField]
	private Lightbox closeBg; //Field offset: 0x28
	[SerializeField]
	private Button tradeBtn; //Field offset: 0x30
	[SerializeField]
	private GameObject artifactsInventoryContainer; //Field offset: 0x38
	[SerializeField]
	private GameObject artifactsInventoryOffersContainer; //Field offset: 0x40
	[SerializeField]
	private GameObject invalidTradeObj; //Field offset: 0x48
	[SerializeField]
	private GameObject validTradeObj; //Field offset: 0x50
	[SerializeField]
	private GameObject artifactsMerchantContainer; //Field offset: 0x58
	[SerializeField]
	private GameObject artifactsMerchantOffersContainer; //Field offset: 0x60
	[SerializeField]
	private GameObject artifactDisplayPrefab; //Field offset: 0x68
	[SerializeField]
	private NK_TextMeshProUGUI inventoryPowerTxt; //Field offset: 0x70
	[SerializeField]
	private NK_TextMeshProUGUI merchantPowerTxt; //Field offset: 0x78
	[SerializeField]
	private NK_TextMeshProUGUI artifactNameTxt; //Field offset: 0x80
	[SerializeField]
	private NK_TextMeshProUGUI artifactDescTxt; //Field offset: 0x88
	[SerializeField]
	private GameObject[] tradeUnavailableObjs; //Field offset: 0x90
	private RogueArtifactDisplayIcon selectedMerchantIcon; //Field offset: 0x98
	private RogueArtifactDisplayIcon selectedInventoryIcon; //Field offset: 0xA0
	private List<RogueArtifactDisplayIcon> activeInventoryIcons; //Field offset: 0xA8
	private List<RogueArtifactDisplayIcon> activeMerchantIcons; //Field offset: 0xB0
	private List<RogueArtifactDisplayIcon> selectedInventoryArtifactIcons; //Field offset: 0xB8
	private List<RogueArtifactDisplayIcon> selectedMerchantArtifactIcons; //Field offset: 0xC0
	private RogueTile merchantTile; //Field offset: 0xC8
	private readonly int maxMerchantOffers; //Field offset: 0xD0
	private int tradesCompleted; //Field offset: 0xD4
	private List<ArtifactLoot> lootToShow; //Field offset: 0xD8
	private int tokensSpent; //Field offset: 0xE0

	private LegendsDataModel LegendsData
	{
		private get { } //Length: 81
	}

	private RogueGameSaveData RogueSaveData
	{
		private get { } //Length: 227
	}

	public RogueMerchantPanel() { }

	[CompilerGenerated]
	private void <ShowLootPopups>b__45_0() { }

	private void AddInventoryIconToOffer(RogueArtifactDisplayIcon artifactIcon) { }

	private void AddMerchantIconToOffer(RogueArtifactDisplayIcon artifactIcon) { }

	private void Awake() { }

	public void Close() { }

	private LegendsDataModel get_LegendsData() { }

	private RogueGameSaveData get_RogueSaveData() { }

	private int GetTotalPower(List<RogueArtifactDisplayIcon> fromIcons, bool isMerchant) { }

	private void KillSoundLoop() { }

	private void MakeTrade() { }

	private void MerchantArtifactSelected(RogueArtifactDisplayIcon artifactIcon) { }

	public void Open(RogueTile merchantTile) { }

	private void PlayerArtifactSelected(RogueArtifactDisplayIcon artifactIcon) { }

	private void PopulateIcons() { }

	public void PopulateInventoryArtifacts() { }

	public void PopulateMerchantArtifacts(int tileSeed) { }

	private void RefreshIconList(List<RogueArtifactDisplayIcon> icons) { }

	private void RefreshUIs() { }

	private void RemoveInventoryIconFromOffer(RogueArtifactDisplayIcon artifactIcon) { }

	private void RemoveMerchantIconFromOffer(RogueArtifactDisplayIcon artifactIcon) { }

	private void ShowLootPopups() { }

}

