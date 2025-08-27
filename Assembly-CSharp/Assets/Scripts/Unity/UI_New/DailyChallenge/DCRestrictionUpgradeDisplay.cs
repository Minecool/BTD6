namespace Assets.Scripts.Unity.UI_New.DailyChallenge;

public class DCRestrictionUpgradeDisplay : MonoBehaviour
{
	public Image img; //Field offset: 0x20
	public GameObject restrictedIconObj; //Field offset: 0x28
	public GameObject abilityIconObj; //Field offset: 0x30
	public NK_TextMeshProUGUI upgradeName; //Field offset: 0x38
	public DCModTowerPathRestriction parent; //Field offset: 0x40
	public GameObject abilityIcon; //Field offset: 0x48
	public CustomDcSliderWithDeadzone slider; //Field offset: 0x50
	public Button zeroButton; //Field offset: 0x58
	public int buttonNumber; //Field offset: 0x60
	private TowerData towerData; //Field offset: 0x68
	public int path; //Field offset: 0x70
	private int tier; //Field offset: 0x74

	public int Tier
	{
		 get { } //Length: 4
	}

	public bool TierZeroDisabled
	{
		 get { } //Length: 144
	}

	public DCRestrictionUpgradeDisplay() { }

	public void ButtonClicked(Slider slider, int value, bool draggingSlider) { }

	public void EnableOrDisable(bool disable) { }

	public int get_Tier() { }

	public bool get_TierZeroDisabled() { }

	public void Initialise(DCModTowerPathRestriction parent, int path, int tier, TowerData towerData, bool isDisabled) { }

	public void SliderTriggeredSetZeroState(bool disable) { }

}

