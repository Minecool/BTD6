namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class CashPerBananaFarmInRange : AbilityBehavior
{
	private const float MaxCashAmount = 10000; //Field offset: 0x0
	public CashPerBananaFarmInRangeModel mdol; //Field offset: 0x68

	public CashPerBananaFarmInRange() { }

	public virtual void Activate() { }

	public virtual bool CanUseAbility() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

