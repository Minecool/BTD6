namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class DestroyIfTargetLost : ProjectileBehavior
{
	public DestroyIfTargetLostModel destroyIfTargetLostModel; //Field offset: 0x68

	public DestroyIfTargetLost() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

