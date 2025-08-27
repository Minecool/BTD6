namespace Assets.Scripts.Data.Behaviors.Events.Actions;

public class ToggleTowerUpgradeScreenAction : HudModifier
{
	[TowerType]
	public string tower; //Field offset: 0x28
	public ToggleModdifier showTowerUpgradesScreen; //Field offset: 0x30

	public virtual Model Model
	{
		 get { } //Length: 112
	}

	public ToggleTowerUpgradeScreenAction() { }

	public virtual Model get_Model() { }

}

