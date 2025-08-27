namespace Assets.Scripts.Unity.UI_New.Main.HeroSelect;

public class HeroSkinButton : MonoBehaviour
{
	public GameObject buyPanel; //Field offset: 0x20
	public GameObject newPanel; //Field offset: 0x28
	public GameObject notificationPanel; //Field offset: 0x30
	public GameObject storePanel; //Field offset: 0x38
	public NK_TextMeshProUGUI txtBuy; //Field offset: 0x40
	public NK_TextMeshProUGUI orgBuyTxt; //Field offset: 0x48
	public Animator heroButtonUnlockEffect; //Field offset: 0x50
	public Image heroIcon; //Field offset: 0x58
	public Image selectedIcon; //Field offset: 0x60
	public Animator unlockEffect; //Field offset: 0x68
	public GameObject[] selectedHeroEffect; //Field offset: 0x70
	private SkinData skinData; //Field offset: 0x78
	private SpriteReference currentIcon; //Field offset: 0x80
	private HeroUpgradeDetails screen; //Field offset: 0x88

	private Btd6Player Player
	{
		private get { } //Length: 7
	}

	public HeroSkinButton() { }

	public void Awake() { }

	private Btd6Player get_Player() { }

	public void Init(SkinData skinData, HeroUpgradeDetails screen) { }

	public void OnClick() { }

	public void UpdateVisuals() { }

}

