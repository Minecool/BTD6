namespace Assets.Scripts.Models.Artifacts.Behaviors;

[Implementation(typeof(ProjectileCarouselBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ProjectileCarouselBehaviorModel : ItemArtifactBehaviorModel
{
	public String[] applyOnlyIfScriptExists; //Field offset: 0x30
	public String[] dontApplyIfScriptExists; //Field offset: 0x38
	public String[] towerTypes; //Field offset: 0x40
	public bool inverseTowerTypes; //Field offset: 0x48
	public TowerSet[] towerSets; //Field offset: 0x50
	public TowerSet towerSet; //Field offset: 0x58
	public bool inverseSets; //Field offset: 0x5C
	public Int32[] tiers; //Field offset: 0x60
	public bool tiersMustBeEqual; //Field offset: 0x68
	public bool inverseTiers; //Field offset: 0x69

	public ProjectileCarouselBehaviorModel(string name, String[] applyOnlyIfScriptExists, String[] dontApplyIfScriptExists, String[] towerTypes, bool inverseTowerTypes, TowerSet[] towerSets, bool inverseSets, Int32[] tiers, bool tiersMustBeEqual, bool inverseTiers) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

