namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(CashIncrease), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CashIncreaseModel : TowerBehaviorModel
{
	public float increase; //Field offset: 0x30
	public float multiplier; //Field offset: 0x34

	public CashIncreaseModel(string name, float increase, float multiplier) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

