namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class RoundBasedAttackSpeed : TowerBehavior
{
	public class RateMutator : BehaviorMutator
	{
		private float attackSpeedPercentIncrease; //Field offset: 0x70
		private float maxWeaponAttackSpeed; //Field offset: 0x74

		public RateMutator(string mutatorId, float attackSpeedPercentIncrease, float maxWeaponAttackSpeed) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public RoundBasedAttackSpeedModel roundBasedAttackSpeedModel; //Field offset: 0x68
	private float numRoundsPassed; //Field offset: 0x70
	private RateMutator mutator; //Field offset: 0x78

	public RoundBasedAttackSpeed() { }

	private void ApplyRoundBasedAttackSpeed() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void OnRoundComplete(int roundNo) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

