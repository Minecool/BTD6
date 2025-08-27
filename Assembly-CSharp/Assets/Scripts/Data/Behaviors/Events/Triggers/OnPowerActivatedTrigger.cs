namespace Assets.Scripts.Data.Behaviors.Events.Triggers;

public class OnPowerActivatedTrigger : EntityTrigger
{
	[SerializeField]
	public String[] powerIds; //Field offset: 0x28

	public virtual Model Model
	{
		 get { } //Length: 90
	}

	public OnPowerActivatedTrigger() { }

	public virtual Model get_Model() { }

}

