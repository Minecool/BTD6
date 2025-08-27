namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class HealOnTowerSellAction : BloonBehaviorAction
{
	public HealOnTowerSellActionModel healOnTowerSellActionModel; //Field offset: 0x78

	public HealOnTowerSellAction() { }

	private int Heal(int heal) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

