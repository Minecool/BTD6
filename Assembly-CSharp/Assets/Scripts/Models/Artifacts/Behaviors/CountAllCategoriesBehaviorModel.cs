namespace Assets.Scripts.Models.Artifacts.Behaviors;

[Implementation(typeof(CountAllCategoriesBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CountAllCategoriesBehaviorModel : ItemArtifactBehaviorModel
{
	internal class TowerSetMutator : BehaviorMutator
	{
		private TowerSet towerSet; //Field offset: 0x70

		public TowerSetMutator(bool isUnique, string mutatorId, TowerSet towerSet, BuffIndicatorModel buffIndicator) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public TowerSet[] towerSetList; //Field offset: 0x30
	public TowerSet towerSet; //Field offset: 0x38
	public bool inverseTowerSets; //Field offset: 0x3C
	public String[] towerTypes; //Field offset: 0x40
	public bool inverseTowerTypes; //Field offset: 0x48
	public Int32[] tiers; //Field offset: 0x50
	public bool tiersMustBeEqual; //Field offset: 0x58
	public bool inverseTiers; //Field offset: 0x59
	public TowerSet[] alsoCountsAsList; //Field offset: 0x60
	public TowerSet alsoCountsAs; //Field offset: 0x68
	private TowerSetMutator mutator; //Field offset: 0x70

	public TowerSetMutator Mutator
	{
		 get { } //Length: 327
	}

	public CountAllCategoriesBehaviorModel(string name, TowerSet[] towerSetList, TowerSet[] alsoCountsAsList, bool inverseTowerSets, String[] towerTypes, bool inverseTowerTypes, Int32[] tiers, bool tiersMustBeEqual, bool inverseTiers) { }

	public virtual Model Clone() { }

	public TowerSetMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

