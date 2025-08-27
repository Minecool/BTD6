namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(DuplicateProjectilePerEmit), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DuplicateProjectilePerEmitModel : WeaponBehaviorModel
{
	public ProjectileModel originalProjectileModel; //Field offset: 0x30
	public int forProjectileCount; //Field offset: 0x38
	public int additionalProjectiles; //Field offset: 0x3C
	public float angleOffset; //Field offset: 0x40
	public int animationState; //Field offset: 0x44
	public int animationStateBeforeChangedProjectile; //Field offset: 0x48
	public EffectModel effectBeforeDuplicatedProjectileModel; //Field offset: 0x50
	public float effectMarkerX; //Field offset: 0x58
	public float effectMarkerY; //Field offset: 0x5C
	public float effectMarkerZ; //Field offset: 0x60

	public DuplicateProjectilePerEmitModel(string name, ProjectileModel originalProjectileModel, int forProjectileCount, int additionalProjectiles, float angleOffset, int animationState, int animationStateBeforeChangedProjectile, EffectModel effectBeforeDuplicatedProjectileModel, float effectMarkerX, float effectMarkerY, float effectMarkerZ) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

