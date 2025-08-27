namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class DuplicateProjectilePerEmit : WeaponBehavior
{
	public DuplicateProjectilePerEmit parent; //Field offset: 0x90
	public Projectile originalProjectile; //Field offset: 0x98
	public Projectile expOriginalProjectile; //Field offset: 0xA0
	public int forProjectileCount; //Field offset: 0xA8
	public string expForProjectileCount; //Field offset: 0xB0
	public int additionalProjectiles; //Field offset: 0xB8
	public string expAdditionalProjectiles; //Field offset: 0xC0
	public float angleOffset; //Field offset: 0xC8
	public string expAngleOffset; //Field offset: 0xD0
	public int animationState; //Field offset: 0xD8
	public string expAnimationState; //Field offset: 0xE0
	public Effect effectBeforeDuplicatedProjectile; //Field offset: 0xE8
	public Effect expEffectBeforeChangedProjectile; //Field offset: 0xF0
	public int animationStateBeforeChangedProjectile; //Field offset: 0xF8
	public string expAnimationStateBeforeChangedProjectile; //Field offset: 0x100
	public GameObject effectMarker; //Field offset: 0x108
	public GameObject expEffectMarker; //Field offset: 0x110

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 743
	}

	public DuplicateProjectilePerEmit() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

