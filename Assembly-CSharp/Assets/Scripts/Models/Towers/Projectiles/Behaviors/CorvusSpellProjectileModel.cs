namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(CorvusSpellProjectile), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CorvusSpellProjectileModel : ProjectileBehaviorModel
{
	public CorvusSpellType spellType; //Field offset: 0x38

	public CorvusSpellProjectileModel(string name, CorvusSpellType spellType) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

