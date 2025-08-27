namespace Assets.Scripts.Unity.Towers.Emissions;

public abstract class EmissionBehavior : CascadingItemProxy
{

	public abstract EmissionBehaviorModel Def
	{
		 get { } //Length: 0
	}

	public virtual Model Model
	{
		 get { } //Length: 20
	}

	protected EmissionBehavior() { }

	public abstract EmissionBehaviorModel get_Def() { }

	public virtual Model get_Model() { }

}

