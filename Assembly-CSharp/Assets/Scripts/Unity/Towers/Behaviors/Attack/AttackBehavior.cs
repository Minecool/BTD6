namespace Assets.Scripts.Unity.Towers.Behaviors.Attack;

public abstract class AttackBehavior : CascadingItemProxy
{

	public abstract AttackBehaviorModel Def
	{
		 get { } //Length: 0
	}

	public virtual Model Model
	{
		 get { } //Length: 20
	}

	protected AttackBehavior() { }

	public abstract AttackBehaviorModel get_Def() { }

	public virtual Model get_Model() { }

}

