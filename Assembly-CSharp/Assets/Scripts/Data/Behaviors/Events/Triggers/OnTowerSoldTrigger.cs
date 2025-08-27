namespace Assets.Scripts.Data.Behaviors.Events.Triggers;

public class OnTowerSoldTrigger : EntityTrigger
{
	[SerializeField]
	public String[] towerIds; //Field offset: 0x28

	public virtual Model Model
	{
		 get { } //Length: 90
	}

	public OnTowerSoldTrigger() { }

	public virtual Model get_Model() { }

}

