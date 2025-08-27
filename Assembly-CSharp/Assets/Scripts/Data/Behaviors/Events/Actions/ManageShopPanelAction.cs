namespace Assets.Scripts.Data.Behaviors.Events.Actions;

public class ManageShopPanelAction : HudModifier
{
	[TowerType]
	public string setSelectedTowerButton; //Field offset: 0x28
	public int lockTowerButtonSelectionIndex; //Field offset: 0x30
	public ToggleModdifier playButton; //Field offset: 0x34
	public ToggleModdifier playButtonInteractable; //Field offset: 0x38
	public ToggleModdifier powerButton; //Field offset: 0x3C
	public ToggleModdifier towersUpgradesButton; //Field offset: 0x40
	public ToggleModdifier towersUpgradesButtonInteractable; //Field offset: 0x44
	public ToggleModdifier toggleTowerUpgradesButtonAnimation; //Field offset: 0x48
	public ToggleModdifier showGoButtonAnimation; //Field offset: 0x4C
	public ToggleModdifier unlockTowerIndex; //Field offset: 0x50
	public ToggleModdifier settingDisableAutoplay; //Field offset: 0x54
	public ToggleModdifier settingDisableSelectingOtherTowers; //Field offset: 0x58

	public virtual Model Model
	{
		 get { } //Length: 272
	}

	public ManageShopPanelAction() { }

	public virtual Model get_Model() { }

}

