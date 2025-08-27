namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities;

public abstract class AbilityBehavior : CascadingItemProxy
{

	public abstract AbilityBehaviorModel Def
	{
		 get { } //Length: 0
	}

	public override GameObject Display
	{
		 get { } //Length: 3
	}

	public virtual Model Model
	{
		 get { } //Length: 20
	}

	protected AbilityBehavior() { }

	public abstract AbilityBehaviorModel get_Def() { }

	public override GameObject get_Display() { }

	public virtual Model get_Model() { }

}

