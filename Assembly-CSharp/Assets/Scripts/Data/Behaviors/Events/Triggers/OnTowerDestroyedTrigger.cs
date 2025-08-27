namespace Assets.Scripts.Data.Behaviors.Events.Triggers;

public class OnTowerDestroyedTrigger : EntityTrigger
{
	[SerializeField]
	public String[] towerIds; //Field offset: 0x28

	public virtual Model Model
	{
		 get { } //Length: 90
	}

	public OnTowerDestroyedTrigger() { }

	public virtual Model get_Model() { }

}

