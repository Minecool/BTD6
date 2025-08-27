namespace Assets.Scripts.Unity.Behaviors.Events.Actions;

public class ShowGlowOnTowerButtonAction : HudModifier
{
	[TowerType]
	public string tower; //Field offset: 0x18
	public ToggleModdifier showGlowOnTowerButton; //Field offset: 0x20

	public virtual Model Model
	{
		 get { } //Length: 112
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public ShowGlowOnTowerButtonAction() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

