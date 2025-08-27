namespace Assets.Scripts.Simulation.Map;

public class LinearRoundBasedCost : FormulaicCost
{
	private LinearRoundBasedCostModel costModel; //Field offset: 0x68

	public LinearRoundBasedCost() { }

	public virtual float CalculateCost() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

