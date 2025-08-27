namespace Assets.Scripts.Unity.Towers.Filters;

public abstract class Filter : CascadingItemProxy
{

	public abstract FilterModel Def
	{
		 get { } //Length: 0
	}

	public virtual Model Model
	{
		 get { } //Length: 20
	}

	protected Filter() { }

	public abstract FilterModel get_Def() { }

	public virtual Model get_Model() { }

}

