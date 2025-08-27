namespace Assets.Scripts.Data.Behaviors;

public abstract class Entity : Behavior, IEntity
{

	public abstract T Def
	{
		 get { } //Length: 0
	}

	public abstract EntityEvent[] Events
	{
		 get { } //Length: 0
	}

	public virtual Model Model
	{
		 get { } //Length: 20
	}

	protected Entity`1() { }

	public abstract T get_Def() { }

	public abstract EntityEvent[] get_Events() { }

	public virtual Model get_Model() { }

	protected Model[] GetBehaviorModelsWithEvents(Behavior[] behaviors) { }

}

