namespace Assets.Scripts.Models.Artifacts.Behaviors;

[Implementation(typeof(AddBehaviorsArtifact), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public abstract class AddBehaviorArtifactBaseModel : ItemArtifactBehaviorModel
{
	internal abstract class AddBehaviorArtifactModel : AddBehaviorArtifactBaseModel
	{
		internal class AddBehaviorsMutator : BehaviorMutator
		{
			private AddBehaviorArtifactBaseModel addBehaviorArtifactBaseModel; //Field offset: 0x0

			public AddBehaviorsMutator(string mutatorName, AddBehaviorArtifactBaseModel addBehaviorArtifactBaseModel) { }

			private bool AddBehaviorToModel(TModel matchingModel) { }

			public virtual bool Mutate(Model baseModel, Model model) { }

		}

		[ExtendedDrawer]
		[SerializeReference]
		public TBehaviorModel[] behaviorModels; //Field offset: 0x0
		private AddBehaviorsMutator<TBehaviorModel, TModel> mutator; //Field offset: 0x0

		protected AddBehaviorArtifactModel`2(string name, String[] addOnlyIfScriptsExists, String[] dontAddIfScriptsExists, String[] replaceScriptNames, String[] replaceScriptIds, String[] towerTypes, bool inverseTowerTypes, TowerSet[] towerSets, bool inverseSets, Int32[] tiers, bool tiersMustBeEqual, bool inverseTiers, bool ignoreSubTowers, bool ignorePowerTowers) { }

		private bool CheckModelName(Model model) { }

		public virtual Model[] GetBehaviorModelsToAdd() { }

		public virtual BehaviorMutator GetBehaviorMutator() { }

		public virtual bool IsTowerModelValid(TowerModel towerModel, TowerModel originalTowerModel) { }

	}

	public String[] addOnlyIfScriptsExists; //Field offset: 0x30
	public String[] dontAddIfScriptsExists; //Field offset: 0x38
	public String[] replaceScriptNames; //Field offset: 0x40
	public String[] replaceScriptIds; //Field offset: 0x48
	public String[] towerTypes; //Field offset: 0x50
	public bool inverseTowerTypes; //Field offset: 0x58
	public TowerSet[] towerSets; //Field offset: 0x60
	public TowerSet towerSet; //Field offset: 0x68
	public bool inverseSets; //Field offset: 0x6C
	public Int32[] tiers; //Field offset: 0x70
	public bool tiersMustBeEqual; //Field offset: 0x78
	public bool inverseTiers; //Field offset: 0x79
	public bool ignoreSubTowers; //Field offset: 0x7A
	public bool ignorePowerTowers; //Field offset: 0x7B

	protected AddBehaviorArtifactBaseModel(string name, String[] addOnlyIfScriptsExists, String[] dontAddIfScriptsExists, String[] replaceScriptNames, String[] replaceScriptIds, String[] towerTypes, bool inverseTowerTypes, TowerSet[] towerSets, bool inverseSets, Int32[] tiers, bool tiersMustBeEqual, bool inverseTiers, bool ignoreSubTowers, bool ignorePowerTowers) { }

	public abstract Model[] GetBehaviorModelsToAdd() { }

	public abstract BehaviorMutator GetBehaviorMutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public abstract bool IsTowerModelValid(TowerModel towerModel, TowerModel originalTowerModel) { }

}

