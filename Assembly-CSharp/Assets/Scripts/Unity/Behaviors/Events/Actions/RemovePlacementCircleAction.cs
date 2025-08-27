namespace Assets.Scripts.Unity.Behaviors.Events.Actions;

public class RemovePlacementCircleAction : HudModifier
{
	public string placementId; //Field offset: 0x18

	public virtual Model Model
	{
		 get { } //Length: 90
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public RemovePlacementCircleAction() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

