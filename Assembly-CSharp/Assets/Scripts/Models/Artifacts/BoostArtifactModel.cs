namespace Assets.Scripts.Models.Artifacts;

[Implementation(typeof(BoostArtifact), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BoostArtifactModel : ArtifactModelWithBehaviors<BoostArtifactBehaviorModel>
{
	public String[] towerTypes; //Field offset: 0x88
	public bool inverseTowerTypes; //Field offset: 0x90
	public TowerSet[] towerSets; //Field offset: 0x98
	public TowerSet towerSet; //Field offset: 0xA0
	public bool inverseSets; //Field offset: 0xA4
	public Int32[] tiers; //Field offset: 0xA8
	public bool tiersMustBeEqual; //Field offset: 0xB0
	public bool inverseTiers; //Field offset: 0xB1

	public BoostArtifactModel(string name, int tier, string baseId, BoostArtifactBehaviorModel[] artifactBehaviors, string nameLocKey, string descriptionLocKey, String[] descriptionParams, SpriteReference icon, string rarityFrameType, String[] towerTypes, bool inverseTowerTypes, TowerSet[] towerSets, bool inverseSets, Int32[] tiers, bool tiersMustBeEqual, bool inverseTiers) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

