namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class EmitOnDamage : ProjectileBehavior
{
	public EmitOnDamageModel emitOnPopImprovedModel; //Field offset: 0x68
	private Emission emission; //Field offset: 0x70
	private float fractionalPierce; //Field offset: 0x78

	public EmitOnDamage() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

