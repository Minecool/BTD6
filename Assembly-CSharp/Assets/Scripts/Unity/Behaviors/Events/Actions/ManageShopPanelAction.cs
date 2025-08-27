namespace Assets.Scripts.Unity.Behaviors.Events.Actions;

public class ManageShopPanelAction : HudModifier
{
	[TowerType]
	public string setSelectedTowerButton; //Field offset: 0x18
	public int lockTowerButtonSelectionIndex; //Field offset: 0x20
	public ToggleModdifier playButton; //Field offset: 0x24
	public ToggleModdifier playButtonInteractable; //Field offset: 0x28
	public ToggleModdifier powerButton; //Field offset: 0x2C
	public ToggleModdifier towersUpgradesButton; //Field offset: 0x30
	public ToggleModdifier towersUpgradesButtonInteractable; //Field offset: 0x34
	public ToggleModdifier toggleTowerUpgradesButtonAnimation; //Field offset: 0x38
	public ToggleModdifier showGoButtonAnimation; //Field offset: 0x3C
	public ToggleModdifier unlockTowerIndex; //Field offset: 0x40
	public ToggleModdifier settingDisableAutoplay; //Field offset: 0x44
	public ToggleModdifier settingDisableSelectingOtherTowers; //Field offset: 0x48

	public virtual Model Model
	{
		 get { } //Length: 272
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public ManageShopPanelAction() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

