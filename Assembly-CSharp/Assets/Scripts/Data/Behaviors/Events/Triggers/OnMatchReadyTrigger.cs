namespace Assets.Scripts.Data.Behaviors.Events.Triggers;

public class OnMatchReadyTrigger : EntityTrigger
{
	public bool triggerOnLoadedSave; //Field offset: 0x28

	public virtual Model Model
	{
		 get { } //Length: 88
	}

	public OnMatchReadyTrigger() { }

	public virtual Model get_Model() { }

}

