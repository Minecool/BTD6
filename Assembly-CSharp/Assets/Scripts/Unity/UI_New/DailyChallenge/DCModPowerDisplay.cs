namespace Assets.Scripts.Unity.UI_New.DailyChallenge;

public class DCModPowerDisplay : DCPowerDisplay
{
	public Button plusBtn; //Field offset: 0x40
	public Button minusBtn; //Field offset: 0x48
	public Button addRemoveBtn; //Field offset: 0x50
	public PowerData powerData; //Field offset: 0x58

	public DCModPowerDisplay() { }

	public void HideButtons() { }

	public void Initialise(PowerData powerData) { }

	public override void MinusClicked() { }

	private void OnDisable() { }

	private void OnEnable() { }

	public override void PlusClicked() { }

	public void ShowPowerCounts(bool show) { }

}

