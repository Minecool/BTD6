namespace Assets.Scripts.Data.Behaviors.Events.Actions;

public class RemovePlacementCircleAction : HudModifier
{
	public string placementId; //Field offset: 0x28

	public virtual Model Model
	{
		 get { } //Length: 90
	}

	public RemovePlacementCircleAction() { }

	public virtual Model get_Model() { }

}

