namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "CollectCreatedProjectile", menuName = "BTD6/Behaviors/Towers/CollectCreatedProjectile")]
public class CollectCreatedProjectile : TowerBehavior
{
	public Projectile projectile; //Field offset: 0x30

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 143
	}

	public CollectCreatedProjectile() { }

	public virtual TowerBehaviorModel get_Def() { }

}

