namespace Assets.Scripts.Simulation.Map;

public abstract class FormulaicCost : RootBehavior
{
	private FormulaicCostModel costModel; //Field offset: 0x58
	public Action OnRoundChanged; //Field offset: 0x60

	protected FormulaicCost() { }

	public override float CalculateCost() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void SimulationRoundStarted(int round) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

