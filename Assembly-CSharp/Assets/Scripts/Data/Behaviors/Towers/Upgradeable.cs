namespace Assets.Scripts.Data.Behaviors.Towers;

public abstract class Upgradeable : Entity<TowerModel>
{

	public virtual Model Model
	{
		 get { } //Length: 20
	}

	protected Upgradeable() { }

	public virtual Model get_Model() { }

}

