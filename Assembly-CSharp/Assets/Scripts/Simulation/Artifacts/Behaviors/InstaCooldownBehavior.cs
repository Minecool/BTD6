namespace Assets.Scripts.Simulation.Artifacts.Behaviors;

public class InstaCooldownBehavior : ItemArtifactBehavior
{
	public InstaCooldownBehaviorModel instaCooldownBehaviorModel; //Field offset: 0x78

	public InstaCooldownBehavior() { }

	public virtual int GetInstaCooldownAddition(string towerType) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

