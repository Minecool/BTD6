namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(RogueGameManager), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RogueGameManagerModel : SimulationBehaviorModel
{
	public Single[] upgradeCostMultipliers; //Field offset: 0x30
	public BossType boss; //Field offset: 0x38
	public int stage; //Field offset: 0x3C
	public bool isFinalBossGame; //Field offset: 0x40

	public RogueGameManagerModel(string name, Single[] upgradeCostMultipliers, BossType boss, int stage, bool isFinalBossGame) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

