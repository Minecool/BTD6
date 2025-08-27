namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

public class UpgradeableProjectileModel : ProjectileBehaviorModel
{
	public float cost; //Field offset: 0x38

	public UpgradeableProjectileModel(string name, float cost) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

