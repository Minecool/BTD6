namespace Assets.Scripts.Models.Entities.Events.Actions;

[Implementation(typeof(ManageShopPanel), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ManageShopPanelModel : EntityActionModel
{
	[TowerType]
	public string setSelectedTowerButton; //Field offset: 0x38
	public int lockTowerButtonSelectionIndex; //Field offset: 0x40
	public ToggleModdifier playButton; //Field offset: 0x44
	public ToggleModdifier playButtonInteractable; //Field offset: 0x48
	public ToggleModdifier powerButton; //Field offset: 0x4C
	public ToggleModdifier towersUpgradesButton; //Field offset: 0x50
	public ToggleModdifier towersUpgradesButtonInteractable; //Field offset: 0x54
	public ToggleModdifier toggleTowerUpgradesButtonAnimation; //Field offset: 0x58
	public ToggleModdifier showGoButtonAnimation; //Field offset: 0x5C
	public ToggleModdifier unlockTowerIndex; //Field offset: 0x60
	public ToggleModdifier settingDisableAutoplay; //Field offset: 0x64
	public ToggleModdifier settingDisableSelectingOtherTowers; //Field offset: 0x68

	public ManageShopPanelModel(string name, ToggleModdifier playButton, ToggleModdifier powerButton, ToggleModdifier showGoButtonAnimation, ToggleModdifier towersUpgradesButton, ToggleModdifier disableAutoplay, ToggleModdifier settingDisableSelectingOtherTowers, ToggleModdifier settingDisableAutoplay, string setSelectedTowerButton, int lockTowerButtonSelectionIndex, ToggleModdifier unlockTowerIndex, ToggleModdifier toggleTowerUpgradesButtonAnimation, ToggleModdifier towersUpgradesButtonInteractable) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

