namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(RushChallengeManager), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RushChallengeManagerModel : SimulationBehaviorModel
{
	internal class RushBloonMutator : BehaviorMutator
	{
		public float speedMultiplier; //Field offset: 0x70
		public float healthMultiplier; //Field offset: 0x74
		public int totalKills; //Field offset: 0x78
		public PrefabReference displaySwap; //Field offset: 0x80
		public DestroyOnDegradeModel destroyOnDegradeModel; //Field offset: 0x88

		public RushBloonMutator(float speedMultiplier, float healthMultiplier, int totalKills, DestroyOnDegradeModel destroyOnDegradeModel, bool isUnique = true, int priority = 1, bool lastAppliesFirst = false, BuffIndicatorModel buffIndicator = null, int stackCount = 0, string saveId = null) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public string targetBloonName; //Field offset: 0x30
	public float badHealthMutliplier; //Field offset: 0x38
	public float badSpeedMutliplier; //Field offset: 0x3C
	public float badScaleMutliplier; //Field offset: 0x40
	public int numAllowedLeaks; //Field offset: 0x44
	public int numRoundsBeforeSpawningTarget; //Field offset: 0x48
	public DestroyOnDegradeModel destroyOnDegradeModel; //Field offset: 0x50

	public RushChallengeManagerModel(string targetBloonName, float badSpeedMutliplier, float badScaleMutliplier, float badHealthMutliplier, int numAllowedLeaks, int numRoundsBeforeSpawningTarget) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

