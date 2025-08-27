namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class HealBloonAction : BloonBehaviorAction
{
	public HealBloonActionModel redirectBloonSpawnActionModel; //Field offset: 0x78

	public HealBloonAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

