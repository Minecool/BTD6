namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu.TowerSelectionMenuThemes;

public class TSMThemeWithActionButton : TSMThemeDefault
{
	public String[] targetTypesToShowButtonFor; //Field offset: 0xD8
	public TSMButton actionButton; //Field offset: 0xE0
	protected readonly TSMInfoModel info; //Field offset: 0xE8
	public bool showOnlyIfTargetTypeActionable; //Field offset: 0xF0
	protected bool hideActionButton; //Field offset: 0xF1

	public TSMThemeWithActionButton() { }

	protected void AddAudioToMenu(TowerToSimulation towerToSim) { }

	public virtual string GetButtonIDTowerSpecial() { }

	public virtual TSMInfoModel OnButtonPress(TowerToSimulation tower, TSMButton button) { }

	public virtual void OnTargetTypeChanged(TowerToSimulation tower) { }

	public virtual void Selected(TowerToSimulation tower, bool openedFromRight) { }

	public virtual void TowerInfoChanged(TowerToSimulation tower) { }

	protected override void UpdateActionButton(TowerToSimulation tower) { }

}

