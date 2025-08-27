namespace Assets.Scripts.Unity.UI_New.DailyChallenge;

public class RogueMentorPanel : MonoBehaviour
{
	internal sealed class OnInstaButtonSelected : MulticastDelegate
	{

		public OnInstaButtonSelected(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(InstaTowerDisplay instaDisplay, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(InstaTowerDisplay instaDisplay) { }

	}

	[SerializeField]
	private GameObject instaTowerDisplayPrefab; //Field offset: 0x20
	[SerializeField]
	private Transform instasContainer; //Field offset: 0x28
	[SerializeField]
	private Button confirmBtn; //Field offset: 0x30
	[SerializeField]
	private Button cancelBtn; //Field offset: 0x38
	[SerializeField]
	private Lightbox cancelBgBtn; //Field offset: 0x40
	[SerializeField]
	private InstaTowerDisplay selectedInstaDisplay; //Field offset: 0x48
	[SerializeField]
	private InstaTowerDisplay[] upgradeInstaDisplays; //Field offset: 0x50
	[SerializeField]
	private GameObject[] upgradeSelectionFx; //Field offset: 0x58
	[SerializeField]
	private NK_TextMeshProUGUI titleText; //Field offset: 0x60
	[SerializeField]
	private NK_TextMeshProUGUI descriptionText; //Field offset: 0x68
	[SerializeField]
	private Button infoBtn; //Field offset: 0x70
	private InstaTowerDisplay selectedUpgrade; //Field offset: 0x78
	private RogueTile campfireTile; //Field offset: 0x80
	private List<GameObject> activeInstaIcons; //Field offset: 0x88

	private LegendsDataModel LegendsData
	{
		private get { } //Length: 81
	}

	private LocalizationManager Locs
	{
		private get { } //Length: 48
	}

	private RogueGameSaveData RogueSaveData
	{
		private get { } //Length: 227
	}

	public RogueMentorPanel() { }

	[CompilerGenerated]
	private bool <ConfirmClicked>b__27_0(RogueInstaMonkey x) { }

	[CompilerGenerated]
	private void <InfoClicked>b__30_0() { }

	private void Awake() { }

	public void Close() { }

	private void ConfirmClicked() { }

	private void DisplayInstas(List<RogueInstaMonkey> instas) { }

	private LegendsDataModel get_LegendsData() { }

	private LocalizationManager get_Locs() { }

	private RogueGameSaveData get_RogueSaveData() { }

	private void InfoClicked() { }

	private void InstaUpgradeClicked(InstaTowerDisplay instaTowerDisplay) { }

	private void InventoryIconClicked(InstaTowerDisplay instaTowerDisplay) { }

	private void KillSoundLoop() { }

	public void Open(RogueTile mentorTile) { }

	private void SetSelectionFx(InstaTowerDisplay instaTowerDisplay) { }

	private void ShowInstaDescription(InstaTowerDisplay instaTowerDisplay) { }

}

