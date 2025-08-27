namespace Assets.Scripts.Models.Map;

public class AbilityCooldownAreaBuffModel : AreaBuffModel
{
	internal class AbilityCooldownAreaBuffMutator : BehaviorMutator
	{
		public float multiplier; //Field offset: 0x70

		public AbilityCooldownAreaBuffMutator(bool isUnique, string mutatorId, BuffIndicatorModel buffIndicator, float multiplier, bool isAreaBuff, bool isArtifactMutator = false) { }

		private bool BuffTowerModel(TowerModel towerModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	private AbilityCooldownAreaBuffMutator mutator; //Field offset: 0x50
	public float multiplier; //Field offset: 0x58

	public AbilityCooldownAreaBuffModel(string name, string mutatorId, int priority, BuffIndicatorModel buffIndicator, float multiplier, TowerSet[] filterInTowerSets) { }

	public virtual Model Clone() { }

	public virtual BehaviorMutator GetMutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

