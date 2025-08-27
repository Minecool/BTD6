namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu.TowerSelectionMenuThemes;

public class BaseTSMTheme : MonoBehaviour
{
	public GameObject infoButton; //Field offset: 0x20
	private string themeId; //Field offset: 0x28

	public string ThemeId
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public BaseTSMTheme() { }

	public string get_ThemeId() { }

	public override string GetButtonIDTowerSpecial() { }

	public override string GetButtonIDTowerSpecial2() { }

	public override void Initialise() { }

	public override void InvokeButtonPress(string buttonId) { }

	public override TSMInfoModel OnButtonPress(PropToSimulation prop, TSMButton button) { }

	public override TSMInfoModel OnButtonPress(TowerToSimulation tower, TSMButton button) { }

	public override void OnSpecialUiEvent(TowerToSimulation selectedTower, string eventId) { }

	public override void OnTargetTypeChanged(TowerToSimulation tower) { }

	public override void OnTargetTypeChanged(PropToSimulation prop) { }

	public override void PropInfoChanged(PropToSimulation prop) { }

	public override void Selected(PropToSimulation prop, bool openedFromRight) { }

	public override void Selected(TowerToSimulation tower, bool openedFromRight) { }

	public void set_ThemeId(string value) { }

	public override void TowerInfoChanged(TowerToSimulation tower) { }

	public override void UpdateFromSimInfo(PropToSimulation prop, Dictionary<String, TSMInfoModel> objects) { }

	public override void UpdateFromSimInfo(TowerToSimulation tower, Dictionary<String, TSMInfoModel> objects) { }

	public override void UpdateName(string nameOverride, bool canEdit) { }

	public override bool WillBumpAbilityButtonPositioning() { }

}

