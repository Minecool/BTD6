namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class DisableDisplaysOnBloon : BloonBehavior
{
	public DisableDisplaysOnBloonModel disableDisplaysOnBloonModel; //Field offset: 0x70

	public DisableDisplaysOnBloon() { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

