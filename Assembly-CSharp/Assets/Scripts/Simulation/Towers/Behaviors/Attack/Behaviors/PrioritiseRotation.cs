namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class PrioritiseRotation : AttackBehavior
{
	public PrioritiseRotationModel prioritiseRotationModel; //Field offset: 0x68
	public float lastProcessedAt; //Field offset: 0x70

	public PrioritiseRotation() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

