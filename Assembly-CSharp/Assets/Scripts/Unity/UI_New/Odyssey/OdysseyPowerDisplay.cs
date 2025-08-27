namespace Assets.Scripts.Unity.UI_New.Odyssey;

public class OdysseyPowerDisplay : DCModPowerDisplay
{
	private OdysseyBoatLoadoutPanel boatLoadoutPanel; //Field offset: 0x60
	private OdysseyEventScreen odysseyEventScreen; //Field offset: 0x68
	public GameObject objLiNKPowersInventoryIcon; //Field offset: 0x70
	public NK_TextMeshProUGUI txtLiNKPowersInventoryIcon; //Field offset: 0x78
	public NK_TextMeshProUGUI txtRedPowerCount; //Field offset: 0x80
	private bool showLiNKPowerData; //Field offset: 0x88

	public OdysseyPowerDisplay() { }

	private void DisplayTextBasedOnLinkInventory(int count, bool overrideRedWhite = false) { }

	public void Initialise(PowerData powerData, OdysseyEventScreen odysseyEventScreen, OdysseyBoatLoadoutPanel boatLoadoutPanel = null, bool showPlusIcon = false, bool showMinusIcon = false, bool showLockedState = false, bool showLiNKPowerData = false) { }

	public virtual void MinusClicked() { }

	public virtual void PlusClicked() { }

	public void SetText(int count, bool showingUsedPowers = false) { }

}

