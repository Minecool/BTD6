namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class DrainLivesAction : BloonBehaviorAction
{
	public DrainLivesActionModel drainLivesActionModel; //Field offset: 0x78

	public DrainLivesAction() { }

	public void CreateText(string content) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

