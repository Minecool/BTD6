namespace Assets.Scripts.Models.Map;

[Implementation(typeof(LinearRoundBasedCost), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class LinearRoundBasedCostModel : FormulaicCostModel
{
	public float costIncrease; //Field offset: 0x38
	public int firstRoundForIncrease; //Field offset: 0x3C
	public int roundsBetweenIncreases; //Field offset: 0x40

	public LinearRoundBasedCostModel(string name, float baseCost, float costIncrease, int firstRoundForIncrease, int roundsBetweenIncreases) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

