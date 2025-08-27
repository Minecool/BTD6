namespace Assets.Scripts.Simulation.Freeplay;

public class ProgressiveDifficultyManager : RootBehavior
{
	public const int fromRound = 81; //Field offset: 0x0
	public const int fromRoundRogue = 31; //Field offset: 0x0
	public static readonly KeyValuePair<Int32, Single>[] roundBasedHealthIncrease; //Field offset: 0x0
	public const float healthIncreaseMax = 99999; //Field offset: 0x0
	public const float superCeramicAdditionalCash = 86; //Field offset: 0x0
	public static readonly KeyValuePair<Int32, Single>[] roundBasedSpeedIncrease; //Field offset: 0x8
	public static readonly KeyValuePair<Int32, Single>[] bonusHealthIncreaseRounds; //Field offset: 0x10
	public static readonly KeyValuePair<Int32, Single>[] bonusSpeedIncreaseRounds; //Field offset: 0x18
	public static readonly Int32[] stunResistanceRounds; //Field offset: 0x20
	public static readonly Single[] stunResistanceAmounts; //Field offset: 0x28
	public static readonly String[] stunMutatorIds; //Field offset: 0x30
	private bool isEnabled; //Field offset: 0x58
	private bool ceramicsChanged; //Field offset: 0x59
	private BloonModel[] bloonModelsOriginal; //Field offset: 0x60

	private static ProgressiveDifficultyManager() { }

	public ProgressiveDifficultyManager() { }

	private void BloonsChangedForModel(GameModel model) { }

	private static void ChangeCeramicsAndChildren(GameModel model, BloonModel[] bloonModelsOriginal) { }

	private static void ChangeSpeedAndHealth(GameModel model, int roundArrayIndex, BloonModel[] bloonModelsOriginal, Simulation sim) { }

	private static void ChangeStunResistance(GameModel model, int roundArrayIndex) { }

	public void CheckRound(int roundArrayIndex, Simulation sim) { }

	public static float GetHealthMultiplier(int roundOnScreen) { }

	private static float GetHealthMultiplierForFirstSpawn(BloonModel bloonModel, Simulation sim) { }

	public BloonModel GetOriginalBloonModel(string id) { }

	public static float GetSpeedMultiplier(int roundOnScreen) { }

	private static float GetStunResistance(int rounds) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void Revert() { }

	private void UpdateDifficulty(int roundArrayIndex, Simulation sim, int fromRound) { }

}

