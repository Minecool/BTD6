namespace Assets.Scripts.Unity.Towers.Emissions;

public abstract class Emission : CascadingItemProxy
{

	public abstract EmissionModel Def
	{
		 get { } //Length: 0
	}

	public virtual Model Model
	{
		 get { } //Length: 20
	}

	protected Emission() { }

	public abstract EmissionModel get_Def() { }

	public virtual Model get_Model() { }

}

