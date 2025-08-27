namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class EmitOnPop : BloonBehavior
{
	private EmitOnPopModel emitOnPopModel; //Field offset: 0x70
	private Emission emission; //Field offset: 0x78
	private bool ignoringSameFrameDegrade; //Field offset: 0x80

	public EmitOnPop() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PreDegrade(DamageResult damageResult, List<Projectile> collidingWith, bool createEffect, Tower tower) { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

