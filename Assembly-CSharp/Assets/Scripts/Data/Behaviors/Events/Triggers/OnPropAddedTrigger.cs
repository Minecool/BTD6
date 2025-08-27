namespace Assets.Scripts.Data.Behaviors.Events.Triggers;

public class OnPropAddedTrigger : EntityTrigger
{
	[SerializeField]
	public String[] propIds; //Field offset: 0x28

	public virtual Model Model
	{
		 get { } //Length: 90
	}

	public OnPropAddedTrigger() { }

	public virtual Model get_Model() { }

}

