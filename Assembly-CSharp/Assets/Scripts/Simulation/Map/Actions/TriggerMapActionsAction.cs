namespace Assets.Scripts.Simulation.Map.Actions;

public class TriggerMapActionsAction : MapAction
{
	private TriggerMapActionsActionModel triggerActionsModel; //Field offset: 0x60
	private List<MapAction> actions; //Field offset: 0x68

	public TriggerMapActionsAction() { }

	public virtual void GotoPreAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

