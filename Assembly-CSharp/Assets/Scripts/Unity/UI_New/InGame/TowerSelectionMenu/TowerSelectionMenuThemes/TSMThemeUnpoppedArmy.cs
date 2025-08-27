namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu.TowerSelectionMenuThemes;

public class TSMThemeUnpoppedArmy : TSMThemeCamo
{
	public TSMButton targetTypeButton; //Field offset: 0xD0
	public NK_TextMeshProUGUI necroCount; //Field offset: 0xD8
	protected readonly TSMInfoModel info; //Field offset: 0xE0

	public TSMThemeUnpoppedArmy() { }

	public virtual string GetButtonIDTowerSpecial2() { }

	public virtual TSMInfoModel OnButtonPress(TowerToSimulation tower, TSMButton button) { }

	public virtual void OnTargetTypeChanged(TowerToSimulation tower) { }

	public virtual void Selected(TowerToSimulation tower, bool openedFromRight) { }

	public virtual void TowerInfoChanged(TowerToSimulation tower) { }

	private void UpdateActionButton(TowerToSimulation tower) { }

	public virtual void UpdateFromSimInfo(TowerToSimulation tower, Dictionary<String, TSMInfoModel> objects) { }

}

