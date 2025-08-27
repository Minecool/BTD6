namespace Assets.Scripts.Unity.Map;

public abstract class FormulaicCost : MonoBehaviour
{

	public abstract FormulaicCostModel Def
	{
		 get { } //Length: 0
	}

	protected FormulaicCost() { }

	public abstract FormulaicCostModel get_Def() { }

}

