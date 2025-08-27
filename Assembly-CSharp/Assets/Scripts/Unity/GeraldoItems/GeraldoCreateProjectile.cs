namespace Assets.Scripts.Unity.GeraldoItems;

public class GeraldoCreateProjectile : GeraldoItemBehavior
{
	[SerializeField]
	private Projectile projectile; //Field offset: 0x10
	[SerializeField]
	public Projectile[] projectileUpgradeModels; //Field offset: 0x18
	[SerializeField]
	public Int32[] projectileModelUpgradeAtLevels; //Field offset: 0x20
	[SerializeField]
	public bool randomRotation; //Field offset: 0x28

	public virtual GeraldoItemBehaviorModel Def
	{
		 get { } //Length: 219
	}

	public GeraldoCreateProjectile() { }

	public virtual GeraldoItemBehaviorModel get_Def() { }

}

