namespace Assets.Scripts.Unity.Behaviors.Events.Actions;

public class ToggleTowerUpgradeScreenAction : HudModifier
{
	[TowerType]
	public string tower; //Field offset: 0x18
	public ToggleModdifier showTowerUpgradesScreen; //Field offset: 0x20

	public virtual Model Model
	{
		 get { } //Length: 112
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public ToggleTowerUpgradeScreenAction() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

	public virtual void ModifyHud(HookCondition condition, object metadata) { }

	private void ShowUpgradesCallback() { }

}

