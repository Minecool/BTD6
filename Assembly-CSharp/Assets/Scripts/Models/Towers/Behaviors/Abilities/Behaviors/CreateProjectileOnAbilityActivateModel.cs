namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(CreateProjectileOnAbilityActivate), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateProjectileOnAbilityActivateModel : AbilityBehaviorModel
{
	public ProjectileModel projectile; //Field offset: 0x30
	public EmissionModel emission; //Field offset: 0x38
	public float chance; //Field offset: 0x40

	public CreateProjectileOnAbilityActivateModel(string name, ProjectileModel projectile, EmissionModel emission, float chance) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

