namespace Assets.Scripts.Data.Behaviors.Events.Actions;

public class ShowGlowOnTowerButtonAction : HudModifier
{
	[TowerType]
	public string tower; //Field offset: 0x28
	public ToggleModdifier showGlowOnTowerButton; //Field offset: 0x30

	public virtual Model Model
	{
		 get { } //Length: 112
	}

	public ShowGlowOnTowerButtonAction() { }

	public virtual Model get_Model() { }

}

