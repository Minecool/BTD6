namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class RemoveAllMutatorsAction : BloonBehaviorAction
{
	public RemoveAllMutatorsActionModel removeAllMutatorsActionModel; //Field offset: 0x78
	private List<TimedMutator> mutatorsToRemove; //Field offset: 0x80

	public RemoveAllMutatorsAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

