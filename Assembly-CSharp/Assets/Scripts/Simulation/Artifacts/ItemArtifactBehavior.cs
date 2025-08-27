namespace Assets.Scripts.Simulation.Artifacts;

public abstract class ItemArtifactBehavior : ArtifactBehaviorBase
{
	public ItemArtifact itemArtifact; //Field offset: 0x68
	public ItemArtifactBehaviorModel itemArtifactBehaviorModel; //Field offset: 0x70

	protected ItemArtifactBehavior() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

}

