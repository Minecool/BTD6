namespace Assets.Scripts.Simulation.Bloons;

public interface IBloonBehavior : IEntityBehavior
{

	public void BeginCollision() { }

	public void Damage(int amount) { }

	public void DamageArmour(int amount) { }

	public void EndCollision() { }

	public bool FilterMutation(BehaviorMutator mutation, ICollection<BehaviorMutatorFilter> filters) { }

	public float GetModifiedDamage(BloonProperties projectileImmuneProperties, BloonProperties originalBloonProperties, float modifiedDamage, Projectile projectile, out bool preventFurtherModifications) { }

	public bool LayersExhaused(DamageResult damageResult) { }

	public DamageResult ModifyDamageResult(DamageResult damageResult) { }

	public void OnImmuneFromHit(bool destroyedTheProjectile) { }

	public void OnSpawn() { }

	public void PostDegrade(DamageResult damageResult, List<Bloon> childrenCreatedOut, List<Projectile> collidingWith, bool createEffect, Tower tower) { }

	public void PreCollision(Projectile proj) { }

	public void PreDegrade(DamageResult damageResult, List<Projectile> collidingWith, bool createEffect, Tower tower) { }

}

