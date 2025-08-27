namespace Assets.Scripts.Unity.UI_New.Main.MonkeySelect;

public class MonkeyButton : MonoBehaviour
{
	public Image towerImage; //Field offset: 0x20
	public Image bgImage; //Field offset: 0x28
	public NK_TextMeshProUGUI towerName; //Field offset: 0x30
	public NK_TextMeshProUGUI xpAmount; //Field offset: 0x38
	public GameObject seenImage; //Field offset: 0x40
	public NK_TextMeshProUGUI seenCountText; //Field offset: 0x48
	public PipEventChecker paragonPip; //Field offset: 0x50
	private MonkeySelectMenu owner; //Field offset: 0x58
	[SerializeField]
	private GameObject giftboxLevelLockObj; //Field offset: 0x60
	[SerializeField]
	private TextMeshProUGUI giftboxLevelLockTxt; //Field offset: 0x68
	public Image lockedImage; //Field offset: 0x70
	public Material standardMaterial; //Field offset: 0x78
	public Material lockedMaterial; //Field offset: 0x80
	public Image giftboxImage; //Field offset: 0x88
	private TowerSet towerSet; //Field offset: 0x90
	public TowerContainerSpritesAsset towerContainerSprites; //Field offset: 0x98
	private string towerId; //Field offset: 0xA0
	public GameObject questLevelLocked; //Field offset: 0xA8
	public GameObject questAvailableToComplete; //Field offset: 0xB0
	public NK_TextMeshProUGUI questRequiredToUnlockTxt; //Field offset: 0xB8
	public NK_TextMeshProUGUI questUnlockProgressTxt; //Field offset: 0xC0
	public GameObject giftBoxFillBarObject; //Field offset: 0xC8
	public Image giftBoxFillBar; //Field offset: 0xD0
	public NK_TextMeshProUGUI giftBoxProgressText; //Field offset: 0xD8

	public MonkeyButton() { }

	public bool CanAcquireUpgrade(UpgradePathModel[] upgrades, int path) { }

	public bool HasNotSeenUpgrade(UpgradePathModel[] upgrades, int path) { }

	public bool HasUpgrade(UpgradePathModel[] upgrades, int path) { }

	public void Init(MonkeySelectMenu owner, string towerId, bool locked) { }

	public void OnClick() { }

}

