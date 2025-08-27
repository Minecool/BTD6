namespace Assets.Scripts.Simulation.Artifacts;

public class ItemArtifact : ArtifactBase
{
	public ItemArtifactModel itemArtifactModel; //Field offset: 0x78

	public ItemArtifact() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

}

