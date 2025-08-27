namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "ChangeProjectilePerEmit", menuName = "BTD6/Behaviors/Weapons/ChangeProjectilePerEmit")]
public class ChangeProjectilePerEmit : WeaponBehavior
{
	public Projectile originalProjectile; //Field offset: 0x30
	public Projectile changedProjectile; //Field offset: 0x38
	public int forProjectileCount; //Field offset: 0x40
	public int animationState; //Field offset: 0x44
	public Effect effectBeforeChangedProjectile; //Field offset: 0x48
	public int animationStateBeforeChangedProjectile; //Field offset: 0x50
	public OffsetPosition effectMarker; //Field offset: 0x58

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 425
	}

	public ChangeProjectilePerEmit() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

