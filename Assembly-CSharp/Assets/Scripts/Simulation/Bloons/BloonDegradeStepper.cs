namespace Assets.Scripts.Simulation.Bloons;

[Il2CppSetOption(Option::NullChecks (1), False)]
[Il2CppSetOption(Option::ArrayBoundsChecks (2), False)]
public class BloonDegradeStepper
{
	internal class DamageResult
	{
		public List<StateInfo> stateInfoPool; //Field offset: 0x10
		public int numOfStates; //Field offset: 0x18
		public int numOfDegrades; //Field offset: 0x1C
		public int damageUsed; //Field offset: 0x20
		public int effectiveDamage; //Field offset: 0x24
		public int changeInLayers; //Field offset: 0x28
		public int nonRegrowDamage; //Field offset: 0x2C
		public float cash; //Field offset: 0x30

		public DamageResult() { }

	}

	internal class StateInfo
	{
		public string bloonModelId; //Field offset: 0x10
		public int health; //Field offset: 0x18

		public StateInfo() { }

	}

	private Simulation Sim; //Field offset: 0x10
	private Dictionary<String, BloonDegradeStep> bloonDegradeStepsByName; //Field offset: 0x18
	private List<BloonDegradeStep> nextChildSteps; //Field offset: 0x20
	private List<BloonDegradeStep> childSteps; //Field offset: 0x28
	private readonly List<Int32> currentHealths; //Field offset: 0x30
	private readonly List<Int32> nextHealths; //Field offset: 0x38
	private readonly List<BloonDegradeStep> currentSteps; //Field offset: 0x40
	private readonly List<BloonDegradeStep> nextSteps; //Field offset: 0x48

	public BloonDegradeStepper() { }

	public void AddCustomStep(BloonModel bloonModel) { }

	public void ClearBaseSteps() { }

	public void ClearCache() { }

	public void ForceUpdate(BloonModel[] bloonModels) { }

	public float GetCashForLayers(BloonModel bloonModel, int layers, int lowestLayer) { }

	public int GetCurrentEffectiveHealth(Bloon bloon, BloonDegradeStep step = null) { }

	public int GetCurrentEffectiveHealthNoRegrow(Bloon bloon) { }

	private int GetCurrentTotalHealth(BloonDegradeStep step, Bloon bloon) { }

	public double GetCurrentTotalHealthPrecise(Bloon bloon) { }

	private int GetDegradesForBloonModel(BloonModel bloonModel) { }

	private int GetEffectiveDamage(BloonDegradeStep step, int hitDamage, int currentLayerHealth) { }

	private int GetLayersForBloonModel(BloonModel bloonModel) { }

	public int GetNonRegrowDamageForLayers(BloonModel bloonModel, int currentHealth, int layers, int lowestLayer, int remainingDamage) { }

	public BloonDegradeStep GetStep(string bloonName) { }

	public int GetTotalBloonHealth(Bloon bloon) { }

	private int GetTotalHealthForBloonModel(BloonModel bloonModel) { }

	public void Initialise(Simulation Sim) { }

	public void RemoveStep(BloonModel bloonModel) { }

	private void ResetDamageResult(DamageResult damageResult) { }

	private void StripExtraChildrenSteps(Bloon bloon, DamageResult result, List<BloonDegradeStep> resultingSteps) { }

	public void UpdateDamageResult(Bloon bloon, int damage, bool distributeToChildren, bool blockSpawnChildren) { }

	private void UpdateDamageResultForDifferentTotalHealths(Bloon bloon, BloonDegradeStep step, DamageResult result, int damage, int currentLayerHealth) { }

}

