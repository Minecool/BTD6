namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class SlowTowersOnPop : BloonBehavior
{
	private SlowTowersOnPopModel slowTowersModel; //Field offset: 0x70
	private bool ignoringSameFrameDegrade; //Field offset: 0x78

	public SlowTowersOnPop() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PreDegrade(DamageResult damageResult, List<Projectile> collidingWith, bool createEffect, Tower tower) { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

