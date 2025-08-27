namespace Assets.Scripts.Unity.UI_New.Main.HeroSelect;

public class HeroUpgradeButton : MonoBehaviour
{
	public NK_TextMeshProUGUI upgradeIndex; //Field offset: 0x20
	public NK_TextMeshProUGUI descriptions; //Field offset: 0x28
	public GameObject highlightEffect; //Field offset: 0x30
	public GameObject icon; //Field offset: 0x38
	public GameObject iconGold; //Field offset: 0x40
	public GameObject iconGoldMaxLevel; //Field offset: 0x48
	public GameObject abilityIconContainer; //Field offset: 0x50
	public GameObject storeIconContainer; //Field offset: 0x58
	public Image abillityIcon; //Field offset: 0x60
	public Image storeIcon; //Field offset: 0x68
	private Button btn; //Field offset: 0x70
	private HeroInGameScreen overridingParentScreen; //Field offset: 0x78
	private HeroUpgradeDetails screen; //Field offset: 0x80
	private SpriteReference portraitSprite; //Field offset: 0x88
	private int heroIndex; //Field offset: 0x90

	public int HeroIndex
	{
		 get { } //Length: 7
	}

	public SpriteReference PortraitSprite
	{
		 get { } //Length: 8
	}

	public HeroUpgradeButton() { }

	public int get_HeroIndex() { }

	public SpriteReference get_PortraitSprite() { }

	public void Highlight() { }

	public void Init(string heroId, int heroIndex, AbilityModel newAbility, bool isSelected, SpriteReference portraitSprite, HeroInGameScreen overridingParentScreen = null, HeroUpgradeDetails screen = null) { }

	public void SetInteractable(bool isOn) { }

	public void StopHighlight() { }

}

