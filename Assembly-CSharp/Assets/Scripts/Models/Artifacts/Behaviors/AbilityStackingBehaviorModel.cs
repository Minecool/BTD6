namespace Assets.Scripts.Models.Artifacts.Behaviors;

[Implementation(typeof(AbilityStackingBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AbilityStackingBehaviorModel : ItemArtifactBehaviorModel
{
	internal class AbilityStackingMutator : BehaviorMutator
	{
		private int stackCount; //Field offset: 0x70

		public AbilityStackingMutator(bool isUnique, string mutatorId, int stackCount, BuffIndicatorModel buffIndicator) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public int stackCount; //Field offset: 0x30
	public String[] towerTypes; //Field offset: 0x38
	public bool inverseTowerTypes; //Field offset: 0x40
	public TowerSet[] towerSets; //Field offset: 0x48
	public TowerSet towerSet; //Field offset: 0x50
	public bool inverseSets; //Field offset: 0x54
	private AbilityStackingMutator mutator; //Field offset: 0x58

	public AbilityStackingMutator Mutator
	{
		 get { } //Length: 244
	}

	public AbilityStackingBehaviorModel(string name, int stackCount, String[] towerTypes, bool inverseTowerTypes, TowerSet[] towerSets, bool inverseSets) { }

	public virtual Model Clone() { }

	public AbilityStackingMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

