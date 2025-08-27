namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class ChangeProjectilePerEmit : WeaponBehavior
{
	public ChangeProjectilePerEmit parent; //Field offset: 0x90
	public Projectile originalProjectile; //Field offset: 0x98
	public Projectile expOriginalProjectile; //Field offset: 0xA0
	public Projectile changedProjectile; //Field offset: 0xA8
	public Projectile expChangedProjectile; //Field offset: 0xB0
	public int forProjectileCount; //Field offset: 0xB8
	public string expForProjectileCount; //Field offset: 0xC0
	public int animationState; //Field offset: 0xC8
	public string expAnimationState; //Field offset: 0xD0
	public Effect effectBeforeChangedProjectile; //Field offset: 0xD8
	public Effect expEffectBeforeChangedProjectile; //Field offset: 0xE0
	public int animationStateBeforeChangedProjectile; //Field offset: 0xE8
	public string expAnimationStateBeforeChangedProjectile; //Field offset: 0xF0
	public GameObject effectMarker; //Field offset: 0xF8
	public GameObject expEffectMarker; //Field offset: 0x100

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 722
	}

	public ChangeProjectilePerEmit() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

