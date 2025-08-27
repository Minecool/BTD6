namespace Assets.Scripts.Unity.Behaviors.Events.Triggers;

public class OnMatchReadyTrigger : EntityTrigger
{
	public bool triggerOnLoadedSave; //Field offset: 0x18

	public virtual Model Model
	{
		 get { } //Length: 88
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public OnMatchReadyTrigger() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

