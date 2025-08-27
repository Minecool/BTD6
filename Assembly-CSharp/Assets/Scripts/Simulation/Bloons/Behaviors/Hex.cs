namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class Hex : BloonBehavior
{
	public HexModel hexModel; //Field offset: 0x70
	public int lastTick; //Field offset: 0x78
	public int firstTick; //Field offset: 0x7C
	private bool appliedFinalDamage; //Field offset: 0x80
	public int ticksLeft; //Field offset: 0x84

	public Hex() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual DamageResult ModifyDamageResult(DamageResult damageResult) { }

	protected virtual void OnDestroy() { }

	public virtual void PostDegrade(DamageResult damageResult, List<Bloon> childrenCreatedOut, List<Projectile> collidingWith, bool createEffect, Tower tower) { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

