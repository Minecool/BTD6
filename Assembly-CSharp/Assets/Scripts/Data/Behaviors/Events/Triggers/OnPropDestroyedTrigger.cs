namespace Assets.Scripts.Data.Behaviors.Events.Triggers;

public class OnPropDestroyedTrigger : EntityTrigger
{
	[SerializeField]
	public String[] propIds; //Field offset: 0x28

	public virtual Model Model
	{
		 get { } //Length: 90
	}

	public OnPropDestroyedTrigger() { }

	public virtual Model get_Model() { }

}

