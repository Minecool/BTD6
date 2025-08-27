namespace Assets.Scripts.Unity.UI_New.Main.HeroSelect;

public class HeroButton : MonoBehaviour
{
	public int mmCost; //Field offset: 0x20
	public Image heroImage; //Field offset: 0x28
	public Image lockedImage; //Field offset: 0x30
	public Material lockedMaterial; //Field offset: 0x38
	public Material standardMaterial; //Field offset: 0x40
	private HeroDetailsModel heroModel; //Field offset: 0x48
	public GameObject[] selectedHeroEffect; //Field offset: 0x50
	public GameObject pipNotification; //Field offset: 0x58
	public GameObject lockedHeroMmPanel; //Field offset: 0x60
	public GameObject monkeyMoneyCost; //Field offset: 0x68
	public GameObject seenIcon; //Field offset: 0x70
	public GameObject saleObj; //Field offset: 0x78
	public NK_TextMeshProUGUI lockedMonkeyMoneyCostText; //Field offset: 0x80
	public NK_TextMeshProUGUI monkeyMoneyCostText; //Field offset: 0x88
	public NK_TextMeshProUGUI lockedLvlUnlockText; //Field offset: 0x90
	public NK_TextMeshProUGUI origionalCostTxt; //Field offset: 0x98
	private bool hasPurchasedHero; //Field offset: 0xA0
	private bool isOnSale; //Field offset: 0xA1
	private bool skinsOnSale; //Field offset: 0xA2
	private int heroUnlockLevel; //Field offset: 0xA4
	private HeroUpgradeDetails screen; //Field offset: 0xA8

	public string HeroId
	{
		 get { } //Length: 27
	}

	public Btd6Player Player
	{
		 get { } //Length: 7
	}

	public int PlayerLevel
	{
		 get { } //Length: 92
	}

	public HeroButton() { }

	public string get_HeroId() { }

	public Btd6Player get_Player() { }

	public int get_PlayerLevel() { }

	public int GetHeroUnlockLevel() { }

	public void Init(HeroUpgradeDetails screen, HeroDetailsModel heroModel, int mmCost, bool isOnSale, bool skinsOnSale) { }

	public void OnClick() { }

	public bool ShowLockIcon() { }

	private bool ShowMonkeyMoneyCost() { }

	private void TogglePip() { }

	private void ToggleSaleBanner() { }

	private void ToggleSelectedEffects(string selectedHeroId) { }

	public void UpdateNotification(bool displayNewIcon = false) { }

	public void UpdatePanel(string selectedHeroId = "") { }

}

