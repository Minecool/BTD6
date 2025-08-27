namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu.TowerSelectionMenuThemes;

public class TSMThemeBeastHandler : TSMThemeWithActionButton
{
	private const int minFramesSinceMove = 120; //Field offset: 0x0
	public TSMButton moveButton; //Field offset: 0xF8
	public TSMButton moveButtonSecond; //Field offset: 0x100
	public Image firstTowerMoveIcon; //Field offset: 0x108
	public Image secondTowerMoveIcon; //Field offset: 0x110
	public Image cooldownFade; //Field offset: 0x118
	public Image cooldownFadeSecond; //Field offset: 0x120
	public GameObject targetPriorityObject; //Field offset: 0x128

	public TSMThemeBeastHandler() { }

	private bool CanMovePet(TowerToSimulation beastHandler, TowerModel petTowerModel) { }

	public virtual string GetButtonIDTowerSpecial() { }

	public virtual string GetButtonIDTowerSpecial2() { }

	public virtual TSMInfoModel OnButtonPress(TowerToSimulation tower, TSMButton button) { }

	public virtual void OnTargetTypeChanged(TowerToSimulation tower) { }

	public virtual void Selected(TowerToSimulation tower, bool openedFromRight) { }

	public virtual void TowerInfoChanged(TowerToSimulation tower) { }

	private void UpdateButtonCooldownState(TSMButton button, Image cooldownFade, int timeOfLastMove, int simElapsed) { }

	public virtual void UpdateFromSimInfo(TowerToSimulation tower, Dictionary<String, TSMInfoModel> objects) { }

	private void UpdateMoveButtonVisibility(TowerToSimulation tower) { }

	private void UpdateSelectTargetButtonVisibility(TowerToSimulation tower) { }

	private void UpdateTargetTypeObjectVisibility(TowerToSimulation tower) { }

}

