namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class DamageBasedAttackSpeed : TowerBehavior
{
	public class RateMutator : BehaviorMutator
	{
		private float attackSpeedPercentIncrease; //Field offset: 0x70

		public RateMutator(string mutatorId, float attackSpeedPercentIncrease) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	private static List<RateMutator> mutators; //Field offset: 0x0
	public DamageBasedAttackSpeedModel damageBasedAttackSpeedModel; //Field offset: 0x68
	private float currentDamage; //Field offset: 0x70
	public float currentDamageThisFrame; //Field offset: 0x74
	public float timeOfLastDamage; //Field offset: 0x78
	public int baseRateFrames; //Field offset: 0x7C
	public int roundStartAdditionalTimeBonus; //Field offset: 0x80
	private RateMutator mutator; //Field offset: 0x88

	public DamageBasedAttackSpeed() { }

	public virtual void Attatched() { }

	private void CreateMutators() { }

	private void FindCurrentMutator() { }

	public int GetRateMultiplier() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnBloonDamaged(Bloon bloon, float amount) { }

	protected virtual void OnDestroy() { }

	public void OverrideMaxStacksAndPops(int overridePopCount) { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateRate() { }

}

