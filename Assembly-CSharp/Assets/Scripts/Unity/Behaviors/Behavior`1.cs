namespace Assets.Scripts.Unity.Behaviors;

public abstract class Behavior : Behavior
{

	[JsonIgnore]
	public abstract T Def
	{
		 get { } //Length: 0
	}

	[JsonIgnore]
	public virtual Model Model
	{
		 get { } //Length: 20
	}

	protected Behavior`1() { }

	public abstract T get_Def() { }

	public virtual Model get_Model() { }

}

