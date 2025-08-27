namespace Assets.Scripts.Data.Behaviors.Events.Triggers;

public class SellTowersAction : EntityAction
{
	[SerializeField]
	public float range; //Field offset: 0x28
	[SerializeField]
	public string towerId; //Field offset: 0x30

	public virtual Model Model
	{
		 get { } //Length: 114
	}

	public SellTowersAction() { }

	public virtual Model get_Model() { }

}

