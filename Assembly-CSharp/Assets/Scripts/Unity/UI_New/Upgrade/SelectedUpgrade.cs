namespace Assets.Scripts.Unity.UI_New.Upgrade;

public class SelectedUpgrade : MonoBehaviour
{
	private const string openParagon = "Paragon Open"; //Field offset: 0x0
	private const string lockedParagon = "Paragon Locked"; //Field offset: 0x0
	private const string locked = "Locked"; //Field offset: 0x0
	private const string open = "Open"; //Field offset: 0x0
	public Image portrait; //Field offset: 0x20
	public Image portraitBackground; //Field offset: 0x28
	private string animationToSet; //Field offset: 0x30
	[FormerlySerializedAs("name")]
	public NK_TextMeshProUGUI upgradeName; //Field offset: 0x38
	public NK_TextMeshProUGUI unlockCost; //Field offset: 0x40
	public NK_TextMeshProUGUI xpUnlockCost; //Field offset: 0x48
	public NK_TextMeshProUGUI paragonXpUnlockCost; //Field offset: 0x50
	public NK_TextMeshProUGUI backgroundUnlockedTxt; //Field offset: 0x58
	public NK_TextMeshProUGUI backgroundParagonUnlockedTxt; //Field offset: 0x60
	public Animator tier5Animation; //Field offset: 0x68
	public Button aquireButton; //Field offset: 0x70
	public Material fastUiMat; //Field offset: 0x78
	public Material grayScaleMat; //Field offset: 0x80
	public Image normalBtnImage; //Field offset: 0x88
	public Image paragonBtnImage; //Field offset: 0x90
	private UpgradeDetails selectedDetails; //Field offset: 0x98
	private bool hasUpgrade; //Field offset: 0xA0
	private string selectedTower; //Field offset: 0xA8

	private bool isParagon
	{
		private get { } //Length: 41
	}

	private string Locked
	{
		private get { } //Length: 108
	}

	private string Open
	{
		private get { } //Length: 108
	}

	public UpgradeDetails SelectedDetails
	{
		 get { } //Length: 8
	}

	public NK_TextMeshProUGUI XpUnlockCost
	{
		 get { } //Length: 66
	}

	public SelectedUpgrade() { }

	private bool get_isParagon() { }

	private string get_Locked() { }

	private string get_Open() { }

	public UpgradeDetails get_SelectedDetails() { }

	public NK_TextMeshProUGUI get_XpUnlockCost() { }

	public void SetUpgrade(string tower, UpgradeDetails details) { }

	public void Update() { }

	public void UpdateButtonState(bool hasUpgrade) { }

	private void UpdateText(bool hasUpgrade) { }

	public void UpdateUpgrade() { }

}

