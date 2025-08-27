namespace Assets.Scripts.Unity.Towers.Mutators.Conditions;

public abstract class Conditional : CascadingItemProxy
{

	public abstract ConditionalModel Def
	{
		 get { } //Length: 0
	}

	public virtual Model Model
	{
		 get { } //Length: 20
	}

	protected Conditional() { }

	public abstract ConditionalModel get_Def() { }

	public virtual Model get_Model() { }

}

