namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu.TowerSelectionMenuThemes;

public class TSMThemeCorvus : TSMThemeWithActionButton
{
	public NK_TextMeshProUGUI manaText; //Field offset: 0xF8
	public Animator gainManaAnimator; //Field offset: 0x100

	public TSMThemeCorvus() { }

	public virtual string GetButtonIDTowerSpecial() { }

	public virtual string GetButtonIDTowerSpecial2() { }

	public virtual TSMInfoModel OnButtonPress(TowerToSimulation tower, TSMButton button) { }

	public virtual void OnSpecialUiEvent(TowerToSimulation selectedTower, string eventId) { }

	public virtual void Selected(TowerToSimulation tower, bool openedFromRight) { }

	public virtual void UpdateFromSimInfo(TowerToSimulation tower, Dictionary<String, TSMInfoModel> objects) { }

	public virtual bool WillBumpAbilityButtonPositioning() { }

}

