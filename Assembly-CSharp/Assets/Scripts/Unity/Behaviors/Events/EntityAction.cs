namespace Assets.Scripts.Unity.Behaviors.Events;

public abstract class EntityAction : Behavior
{

	public virtual string Type
	{
		 get { } //Length: 44
	}

	protected EntityAction() { }

	public virtual string get_Type() { }

}

