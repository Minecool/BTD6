namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(FrozenCascade), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FrozenCascadeModel : AbilityBehaviorModel
{
	public string towerId; //Field offset: 0x30
	public int maxExplosions; //Field offset: 0x38
	public float timeScale; //Field offset: 0x3C
	public EmissionModel emission; //Field offset: 0x40
	public ProjectileModel projectile; //Field offset: 0x48

	public FrozenCascadeModel(string name, string towerId, int maxExplosions, float speed, EmissionModel emission, ProjectileModel projectile) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

