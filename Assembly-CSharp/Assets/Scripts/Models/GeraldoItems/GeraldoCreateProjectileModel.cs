namespace Assets.Scripts.Models.GeraldoItems;

[Implementation(typeof(GeraldoCreateProjectile), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class GeraldoCreateProjectileModel : GeraldoItemBehaviorModel
{
	public ProjectileModel projectileModel; //Field offset: 0x30
	public ProjectileModel[] projectileModelUpgrades; //Field offset: 0x38
	public Int32[] projectileModelUpgradeAtLevels; //Field offset: 0x40
	public bool randomRotation; //Field offset: 0x48

	public GeraldoCreateProjectileModel(string name, ProjectileModel projectileModel, ProjectileModel[] projectileModelUpgrades, Int32[] projectileModelUpgradeAtLevels, bool randomRotation) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

