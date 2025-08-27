namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class SellTrigger : BloonBehaviorTrigger
{
	public SellTriggerModel sellTriggerModel; //Field offset: 0x70
	private List<BloonBehaviorAction> actions; //Field offset: 0x78
	public Tower lastTowerSold; //Field offset: 0x80

	public SellTrigger() { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnTowerSold(Tower tower, float sellWorth, double cashBefore, double cashAfter) { }

	private void Trigger(Tower tower) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

