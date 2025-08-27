namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "TowerFilter", menuName = "BTD6/Behaviors/Towers/TowerFilter")]
public class TowerFilter : EntityBehavior<TowerFilterModel>
{

	public virtual TowerFilterModel Def
	{
		 get { } //Length: 62
	}

	public TowerFilter() { }

	public virtual TowerFilterModel get_Def() { }

}

