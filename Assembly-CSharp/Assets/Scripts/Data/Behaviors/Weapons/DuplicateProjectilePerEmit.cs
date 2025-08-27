namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "DuplicateProjectilePerEmit", menuName = "BTD6/Behaviors/Weapons/DuplicateProjectilePerEmit")]
public class DuplicateProjectilePerEmit : WeaponBehavior
{
	public Projectile originalProjectile; //Field offset: 0x30
	public int forProjectileCount; //Field offset: 0x38
	public int additionalProjectiles; //Field offset: 0x3C
	public float angleOffset; //Field offset: 0x40
	public int animationState; //Field offset: 0x44
	public Effect effectBeforeDuplicatedProjectile; //Field offset: 0x48
	public int animationStateBeforeChangedProjectile; //Field offset: 0x50
	public OffsetPosition effectMarker; //Field offset: 0x58

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 429
	}

	public DuplicateProjectilePerEmit() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

