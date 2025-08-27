namespace Assets.Scripts.Data.Behaviors.Towers.GeraldoItems;

[CreateAssetMenu(fileName = "GeraldoCreateProjectile", menuName = "BTD6/Behaviors/Towers/GeraldoItems/GeraldoCreateProjectile")]
public class GeraldoCreateProjectile : GeraldoItemBehavior
{
	public Projectile projectile; //Field offset: 0x28
	public Projectile[] projectileUpgrades; //Field offset: 0x30
	public Int32[] projectileModelUpgradeAtLevels; //Field offset: 0x38
	public bool randomRotation; //Field offset: 0x40

	public virtual GeraldoItemBehaviorModel Def
	{
		 get { } //Length: 231
	}

	public GeraldoCreateProjectile() { }

	public virtual GeraldoItemBehaviorModel get_Def() { }

}

