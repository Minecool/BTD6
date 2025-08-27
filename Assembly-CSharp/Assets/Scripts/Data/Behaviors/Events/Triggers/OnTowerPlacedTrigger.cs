namespace Assets.Scripts.Data.Behaviors.Events.Triggers;

public class OnTowerPlacedTrigger : EntityTrigger
{
	[SerializeField]
	public String[] towerIds; //Field offset: 0x28

	public virtual Model Model
	{
		 get { } //Length: 90
	}

	public OnTowerPlacedTrigger() { }

	public virtual Model get_Model() { }

}

