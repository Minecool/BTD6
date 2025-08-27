namespace Assets.Scripts.Unity.UI_New.DailyChallenge;

public class DCModTowerDisplay : DCTowerDisplay
{
	public Button plusBtn; //Field offset: 0x48
	public Button minusBtn; //Field offset: 0x50
	public Button addRemoveBtn; //Field offset: 0x58
	public TowerData towerData; //Field offset: 0x60

	public DCModTowerDisplay() { }

	public void DisableRestrictionText() { }

	public void HideButtons() { }

	public override void Init(TowerData towerData) { }

	public override void MinusClicked() { }

	private void OnDisable() { }

	private void OnEnable() { }

	public override void PlusClicked() { }

	public void ShowButtons() { }

	public void ShowTowerCounts(bool show) { }

}

