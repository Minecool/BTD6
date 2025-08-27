namespace Assets.Scripts.Simulation.Bloons;

public abstract class BloonBehavior : EntityBehavior, IBloonBehavior, IEntityBehavior
{
	public Bloon bloon; //Field offset: 0x60
	[CompilerGenerated]
	private readonly float <Radius>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private readonly float <VsBlockerRadius>k__BackingField; //Field offset: 0x6C

	public float Radius
	{
		[CompilerGenerated]
		 get { } //Length: 6
	}

	public float VsBlockerRadius
	{
		[CompilerGenerated]
		 get { } //Length: 6
	}

	protected BloonBehavior() { }

	public override void BeginCollision() { }

	public virtual void Cleanup() { }

	public override void Damage(int amount) { }

	public override void DamageArmour(int amount) { }

	public override void EndCollision() { }

	public override bool FilterMutation(BehaviorMutator mutation, ICollection<BehaviorMutatorFilter> filters) { }

	[CompilerGenerated]
	public float get_Radius() { }

	[CompilerGenerated]
	public float get_VsBlockerRadius() { }

	public override float GetModifiedDamage(BloonProperties projectileImmuneProperties, BloonProperties originalProjectileImmuneProperties, float modifiedDamage, Projectile projectile, out bool preventFurtherModifications) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public override bool LayersExhaused(DamageResult damageResult) { }

	public override DamageResult ModifyDamageResult(DamageResult damageResult) { }

	public override void OnImmuneFromHit(bool destroyedTheProjectile) { }

	public override void OnSpawn() { }

	public override void PostDegrade(DamageResult damageResult, List<Bloon> childrenCreatedOut, List<Projectile> collidingWith, bool createEffect, Tower tower) { }

	public override void PreCollision(Projectile proj) { }

	public override void PreDegrade(DamageResult damageResult, List<Projectile> collidingWith, bool createEffect, Tower tower) { }

}

