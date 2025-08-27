namespace Assets.Scripts.Unity.UI_New.Odyssey;

public class OdysseyTowerDisplay : DCModTowerDisplay
{
	private OdysseyBoatLoadoutPanel boatLoadoutPanel; //Field offset: 0x68
	private OdysseyEventScreen odysseyEventScreen; //Field offset: 0x70
	public TMP_Text towerRestrictiedTxt; //Field offset: 0x78
	private bool showTextCount; //Field offset: 0x80

	public OdysseyTowerDisplay() { }

	public void HideMinusButton() { }

	public void Initialise(TowerData towerData, OdysseyEventScreen odysseyEventScreen, OdysseyBoatLoadoutPanel boatLoadoutPanel = null, bool showPlusIcon = false, bool showMinusIcon = false, bool showLockedState = false, bool showTowerSetBackground = false, bool showTextCount = false, bool useRoundBg = false, bool showRestrictedTxt = false) { }

	public virtual void MinusClicked() { }

	public virtual void PlusClicked() { }

	public void UpdateText(int count, bool showingStatsScreen = false) { }

}

