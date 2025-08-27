namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class PerRoundCashBonusTower : TowerBehavior
{
	private const float cashAsBlopsFraction = 0.1; //Field offset: 0x0
	public PerRoundCashBonusTowerModel perRoundCashBonusTowerModel; //Field offset: 0x68

	public PerRoundCashBonusTower() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnRoundComplete(int roundArrayIndex) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

