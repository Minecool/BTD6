namespace Assets.Scripts.Unity.Behaviors.Events.Triggers;

public class OnPlacementCircleInteraction : EntityTrigger
{
	public String[] placementCircleIds; //Field offset: 0x18
	public bool requireTowerPlacedInCircle; //Field offset: 0x20

	public virtual Model Model
	{
		 get { } //Length: 114
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public OnPlacementCircleInteraction() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

