namespace Assets.Scripts.Unity.Map;

public class LinearRoundBasedCost : FormulaicCost
{
	private LinearRoundBasedCostModel def; //Field offset: 0x20
	public float baseCost; //Field offset: 0x28
	public float costIncrease; //Field offset: 0x2C
	public int firstRoundForIncrease; //Field offset: 0x30
	public int roundsBetweenIncreases; //Field offset: 0x34

	public virtual FormulaicCostModel Def
	{
		 get { } //Length: 241
	}

	public LinearRoundBasedCost() { }

	public virtual FormulaicCostModel get_Def() { }

}

