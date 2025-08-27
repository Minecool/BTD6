namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class GrowBlock : BloonBehavior
{
	public GrowBlockModel growBlockModel; //Field offset: 0x70

	public GrowBlock() { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

