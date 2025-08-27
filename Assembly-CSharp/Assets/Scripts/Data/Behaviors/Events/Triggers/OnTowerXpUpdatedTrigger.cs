namespace Assets.Scripts.Data.Behaviors.Events.Triggers;

public class OnTowerXpUpdatedTrigger : EntityTrigger
{
	[TowerType]
	public String[] towerIds; //Field offset: 0x28

	public virtual Model Model
	{
		 get { } //Length: 90
	}

	public OnTowerXpUpdatedTrigger() { }

	public virtual Model get_Model() { }

}

