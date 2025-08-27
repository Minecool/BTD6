namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(JungleVineLimitProjectile), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class JungleVineLimitProjectileModel : WeaponBehaviorModel
{
	public int limit; //Field offset: 0x30
	public int delayInFrames; //Field offset: 0x34

	public JungleVineLimitProjectileModel(string name, int limit, int delayInFrames) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

