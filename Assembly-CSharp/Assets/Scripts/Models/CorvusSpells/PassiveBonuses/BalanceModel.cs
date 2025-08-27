namespace Assets.Scripts.Models.CorvusSpells.PassiveBonuses;

[Implementation(typeof(Balance), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BalanceModel : TowerBehaviorModel
{
	public float maxGenerationManaPoolThreshold; //Field offset: 0x30
	public float maxGenerationRate; //Field offset: 0x34
	public float minGenerationManaPoolThreshold; //Field offset: 0x38
	public float minGenerationRate; //Field offset: 0x3C

	public BalanceModel(string name, float maxGenerationManaPoolThreshold, float maxGenerationRate, float minGenerationManaPoolThreshold, float minGenerationRate) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

