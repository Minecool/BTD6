namespace Assets.Scripts.Models.Artifacts;

public abstract class ArtifactModelWithBehaviors : ArtifactModelBase
{
	[SerializeReference]
	public T[] artifactBehaviors; //Field offset: 0x0

	protected ArtifactModelWithBehaviors`1(string name, int tier, string baseId, T[] artifactBehaviors, string nameLocKey, string descriptionLocKey, String[] descriptionParams, SpriteReference icon, string rarityFrameType, bool isBossArtifact, bool isQuestArtifact, int merchantCostMultiplier) { }

	public virtual Model[] GetArtifactBehaviorModels() { }

}

