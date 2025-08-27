namespace Assets.Scripts.Models.Artifacts;

[Implementation(typeof(ItemArtifact), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ItemArtifactModel : ArtifactModelWithBehaviors<ItemArtifactBehaviorModel>
{
	[SerializeField]
	private RogueInstaMonkey instaTowerToGive; //Field offset: 0x88

	public ItemArtifactModel(string name, int tier, string baseId, ItemArtifactBehaviorModel[] artifactBehaviors, string nameLocKey, string descriptionLocKey, String[] descriptionParams, SpriteReference icon, string rarityFrameType, bool isBossArtifact, bool isQuestArtifact, RogueInstaMonkey instaTowerToGive, int merchantCostMultiplier) { }

	public virtual Model Clone() { }

	public RogueInstaMonkey GetTower() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

