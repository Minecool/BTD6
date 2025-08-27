namespace Assets.Scripts.Unity.UI_New.Main.DailyRewards;

public class TowerGiftBoxScreen : GameMenu
{
	public Image towerImage; //Field offset: 0x48
	public NK_TextMeshProUGUI countText; //Field offset: 0x50
	public NK_TextMeshProUGUI titleText; //Field offset: 0x58
	public NK_TextMeshProUGUI descriptionText; //Field offset: 0x60
	public Image countImage; //Field offset: 0x68
	public string descriptionLocsKey; //Field offset: 0x70
	public VerticalLayoutGroup layoutGroup; //Field offset: 0x78
	public Button selectButton; //Field offset: 0x80
	public Button getNowButton; //Field offset: 0x88
	private List<TowerUnlockSelectionPanel> panels; //Field offset: 0x90
	private TowerUnlockSelectionPanel currentlyHighlighted; //Field offset: 0x98
	public Button debugForceUnlockButton; //Field offset: 0xA0
	public Button debugResetButton; //Field offset: 0xA8

	public TowerGiftBoxScreen() { }

	public void BackClicked() { }

	public void OnDebugForceUnlock() { }

	public void OnDebugReset() { }

	private void OnGetNowButton() { }

	public void OnPanelClicked(TowerUnlockSelectionPanel selectedPanel) { }

	public void OnPurchaseComplete() { }

	public void OnPurchaseFailed() { }

	private void OnSelectButton() { }

	public virtual void Open(object menuData) { }

	private void SetHighlighted(TowerUnlockSelectionPanel selectedPanel) { }

	protected override void Start() { }

	private void UpdateUI() { }

}

