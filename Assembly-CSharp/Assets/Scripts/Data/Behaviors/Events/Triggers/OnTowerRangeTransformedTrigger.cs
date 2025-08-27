namespace Assets.Scripts.Data.Behaviors.Events.Triggers;

public class OnTowerRangeTransformedTrigger : EntityTrigger
{
	[TowerType]
	public String[] towerIds; //Field offset: 0x28

	public virtual Model Model
	{
		 get { } //Length: 90
	}

	public OnTowerRangeTransformedTrigger() { }

	public virtual Model get_Model() { }

}

