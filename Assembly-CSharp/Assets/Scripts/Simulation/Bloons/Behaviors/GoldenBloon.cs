namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class GoldenBloon : BloonBehavior
{
	public GoldenBloonModel def; //Field offset: 0x70
	private int jumpTimer; //Field offset: 0x78
	private InvulnerableMutator invulnerableMutator; //Field offset: 0x80
	private SpeedUpMutator speedUpMutator; //Field offset: 0x88

	public GoldenBloon() { }

	public virtual void Damage(int amount) { }

	public virtual float GetModifiedDamage(BloonProperties projectileImmuneProperties, BloonProperties originalProjectileImmuneProperties, float modifiedDamage, Projectile projectile, out bool preventFurtherModification) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void PlayDamageFX() { }

	private void PlayRewardTextFX(int mm) { }

	public virtual void PostDegrade(DamageResult damageResult, List<Bloon> childrenCreatedOut, List<Projectile> collidingWith, bool createEffect, Tower tower) { }

	private void Process(int elasped) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

