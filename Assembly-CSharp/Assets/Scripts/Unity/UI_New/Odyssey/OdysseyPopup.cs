namespace Assets.Scripts.Unity.UI_New.Odyssey;

public class OdysseyPopup : MonoBehaviour
{
	public Lightbox btnClose; //Field offset: 0x20
	public object metaData; //Field offset: 0x28
	protected bool initialised; //Field offset: 0x30
	public Animator animator; //Field offset: 0x38
	protected OdysseyEventScreen odysseyEventScreen; //Field offset: 0x40

	public int MaxMonkeySeats
	{
		 get { } //Length: 82
	}

	public int MaxMonkeysOnBoat
	{
		 get { } //Length: 82
	}

	public int MaxPowerSlots
	{
		 get { } //Length: 82
	}

	public int MaxPowersOnBoat
	{
		 get { } //Length: 38
	}

	public Dictionary<String, Int32> MonkeysSelected
	{
		 get { } //Length: 39
	}

	public OdysseyEventScreen OdysseyUi
	{
		 get { } //Length: 5
	}

	public Dictionary<String, Int32> PowersSelected
	{
		 get { } //Length: 39
	}

	public OdysseyPopup() { }

	private void AnimStateEnd() { }

	public int get_MaxMonkeySeats() { }

	public int get_MaxMonkeysOnBoat() { }

	public int get_MaxPowerSlots() { }

	public int get_MaxPowersOnBoat() { }

	public Dictionary<String, Int32> get_MonkeysSelected() { }

	public OdysseyEventScreen get_OdysseyUi() { }

	public Dictionary<String, Int32> get_PowersSelected() { }

	public override void Initialize(OdysseyEventScreen odysseyEventScreen, object metaData) { }

	public override void OnCloseClick() { }

	public override void OnDifficultyChanged() { }

	private void OnDisable() { }

	private void OnEnable() { }

	protected void SetupPowersDisplay(ref List<GameObject>& list, GameObject contentPanel, OdysseyPowerDisplay prefab, bool clearList, List<PowerData> availablePowers = null, bool showPlusIcon = false, bool showMinusIcon = false, OdysseyBoatLoadoutPanel parentPanel = null, bool showLiNKInventoryData = false) { }

	protected void SetupTowersDisplay(ref List<GameObject>& list, List<TowerData> availableTowers, GameObject contentPanel, OdysseyTowerDisplay prefab, bool clearList, bool showPlusIcon = false, bool showMinusIcon = false, OdysseyBoatLoadoutPanel parentPanel = null, bool showTowerSetBackground = false, bool showTowerRestrictedTxt = false) { }

}

