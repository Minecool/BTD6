namespace Assets.Scripts.Unity.Towers.TowerFilters;

public class TowerFilter : CascadingItemProxy
{

	public override TowerFilterModel Def
	{
		 get { } //Length: 3
	}

	public virtual Model Model
	{
		 get { } //Length: 20
	}

	public TowerFilter() { }

	public override TowerFilterModel get_Def() { }

	public virtual Model get_Model() { }

}

