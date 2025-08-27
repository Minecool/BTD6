namespace Assets.Scripts.Unity.UI_New.Popups;

public class RogueLootPopup : Popup
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass42_0
	{
		public RogueInstaMonkey insta; //Field offset: 0x10
		public GameObject newButton; //Field offset: 0x18
		public ArtifactLoot artifact; //Field offset: 0x20
		public RogueLootPopup <>4__this; //Field offset: 0x28

		public <>c__DisplayClass42_0() { }

		internal void <SetLootChoices>b__0() { }

		internal void <SetLootChoices>b__1() { }

	}

	internal sealed class HideRogueLootPopup : MulticastDelegate
	{

		public HideRogueLootPopup(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[SerializeField]
	private GameObject buttonPrefab; //Field offset: 0x128
	[SerializeField]
	private Transform buttonsTransform; //Field offset: 0x130
	[SerializeField]
	private Button rerollBtn; //Field offset: 0x138
	[SerializeField]
	private Button selectBtn; //Field offset: 0x140
	[SerializeField]
	private Button banBtn; //Field offset: 0x148
	[SerializeField]
	private Button instasDisplayBtn; //Field offset: 0x150
	[SerializeField]
	private Button artifactsDisplayBtn; //Field offset: 0x158
	[SerializeField]
	private GameObject banBtnGameObject; //Field offset: 0x160
	[SerializeField]
	private NK_TextMeshProUGUI rerollCostTxt; //Field offset: 0x168
	[SerializeField]
	private NK_TextMeshProUGUI lootTitleTxt; //Field offset: 0x170
	[SerializeField]
	private NK_TextMeshProUGUI lootDescTxt; //Field offset: 0x178
	[SerializeField]
	private NK_TextMeshProUGUI inGameCashTxt; //Field offset: 0x180
	[SerializeField]
	private GameObject inGameCashTxtObj; //Field offset: 0x188
	[SerializeField]
	private RogueLootDisplay rogueLootDisplay; //Field offset: 0x190
	[SerializeField]
	private DisplayArtifactsPanel artifactInvPanel; //Field offset: 0x198
	[SerializeField]
	private GameObject rewardObj; //Field offset: 0x1A0
	[SerializeField]
	private Lightbox rewardBgClose; //Field offset: 0x1A8
	[SerializeField]
	private Button infoBtn; //Field offset: 0x1B0
	[SerializeField]
	private GameObject tokenIconObj; //Field offset: 0x1B8
	[SerializeField]
	private GameObject cashIconObj; //Field offset: 0x1C0
	[SerializeField]
	private GameObject tokenIconBannerObj; //Field offset: 0x1C8
	[SerializeField]
	private GameObject cashIconBannerObj; //Field offset: 0x1D0
	private List<GameObject> activeButtons; //Field offset: 0x1D8
	private bool buttonsLocked; //Field offset: 0x1E0
	private int rerollCount; //Field offset: 0x1E4
	private int freeRerollCount; //Field offset: 0x1E8
	private RogueLoot selectedLoot; //Field offset: 0x1F0
	private GameObject selectedButton; //Field offset: 0x1F8
	private RogueLootData rogueLootData; //Field offset: 0x200
	private ReturnCallback onRewardScreenClosedCallback; //Field offset: 0x208
	private int endOfGameRerolls; //Field offset: 0x210

	private LegendsDataModel LegendsData
	{
		private get { } //Length: 81
	}

	private float RerollCost
	{
		private get { } //Length: 153
	}

	private int RerollTokenCost
	{
		private get { } //Length: 97
	}

	private RogueGameSaveData RogueSaveData
	{
		private get { } //Length: 227
	}

	public RogueLootPopup() { }

	[CompilerGenerated]
	private void <HidePopupWithoutClosing>b__54_0() { }

	[CompilerGenerated]
	private void <InfoClicked>b__53_0() { }

	private void AddArtifactAndClose(ArtifactLoot artifact) { }

	private void AddInstaAndClose(RogueInstaMonkey insta) { }

	public void Awake() { }

	private void BanSelectedTowerType() { }

	public void Bind(ReturnCallback onRewardScreenClosedCallback, RogueLootData rogueLootData) { }

	private void DisplayArtifactsInventory() { }

	private void DisplayInstasInventory() { }

	private LegendsDataModel get_LegendsData() { }

	private float get_RerollCost() { }

	private int get_RerollTokenCost() { }

	private RogueGameSaveData get_RogueSaveData() { }

	private List<RogueLoot> GetLootRandomChoices() { }

	private void HidePopupWithoutClosing() { }

	private void InfoClicked() { }

	private void LootButtonClicked(RogueLoot loot, GameObject button) { }

	private void RerollCampfireRecruitLoot() { }

	private void RerollClicked() { }

	private void RerollInGameLoot() { }

	private void RerollMapLoot() { }

	private void SelectClicked() { }

	public void SetLootChoices() { }

	private void SetupRerollUIs() { }

	private void ShowRewardScreen(RogueLoot loot) { }

}

