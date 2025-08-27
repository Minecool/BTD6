namespace Assets.Scripts.Simulation.Artifacts.Behaviors;

public class GlobalTechBotLinkBehavior : ItemArtifactBehavior
{
	public GlobalTechBotLinkBehaviorModel globalTechBotLinkBehaviorModel; //Field offset: 0x78

	public GlobalTechBotLinkBehavior() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

