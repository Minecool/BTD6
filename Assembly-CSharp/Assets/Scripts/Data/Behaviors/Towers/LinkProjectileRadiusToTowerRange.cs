namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "LinkProjectileRadiusToTowerRange", menuName = "BTD6/Behaviors/Towers/LinkProjectileRadiusToTowerRange")]
public class LinkProjectileRadiusToTowerRange : TowerBehavior
{
	public Projectile projectile; //Field offset: 0x30
	public float projectileRadiusOffset; //Field offset: 0x38
	public float displayRadius; //Field offset: 0x3C
	public Tower tower; //Field offset: 0x40

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 239
	}

	public LinkProjectileRadiusToTowerRange() { }

	public virtual TowerBehaviorModel get_Def() { }

}

