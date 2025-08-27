namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(ChangeProjectilePerEmit), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ChangeProjectilePerEmitModel : WeaponBehaviorModel
{
	public ProjectileModel originalProjectileModel; //Field offset: 0x30
	public ProjectileModel changedProjectileModel; //Field offset: 0x38
	public int forProjectileCount; //Field offset: 0x40
	public int animationState; //Field offset: 0x44
	public int animationStateBeforeChangedProjectile; //Field offset: 0x48
	public EffectModel effectBeforeChangedProjectileModel; //Field offset: 0x50
	public float effectMarkerX; //Field offset: 0x58
	public float effectMarkerY; //Field offset: 0x5C
	public float effectMarkerZ; //Field offset: 0x60

	public ChangeProjectilePerEmitModel(string name, ProjectileModel originalProjectileModel, ProjectileModel changedProjectileModel, int forProjectileCount, int animationState, int animationStateBeforeChangedProjectile, EffectModel effectBeforeChangedProjectileModel, float effectMarkerX, float effectMarkerY, float effectMarkerZ) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

