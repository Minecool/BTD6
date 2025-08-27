namespace Assets.Scripts.Unity.Behaviors.Events;

public abstract class EntityTrigger : Behavior
{

	public virtual string Type
	{
		 get { } //Length: 44
	}

	protected EntityTrigger() { }

	public virtual string get_Type() { }

}

