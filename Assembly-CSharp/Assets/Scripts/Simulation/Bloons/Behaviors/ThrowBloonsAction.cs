namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class ThrowBloonsAction : BloonBehaviorAction
{
	public ThrowBloonsActionModel throwBloonsActionModel; //Field offset: 0x78

	public ThrowBloonsAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void PerformAction() { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

