namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class AddEventHook : SimulationBehavior
{
	public AddEventHookModel behaviorModel; //Field offset: 0x58
	public EventHookToSimulation eventHookToSimulation; //Field offset: 0x60
	public HookCondition startHook; //Field offset: 0x68
	public List<HookCondition> endHooks; //Field offset: 0x70

	public AddEventHook() { }

	public void AttachEventListeners() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void OnEndHookTriggeredCallback(HookCondition condition, object metaData) { }

	public virtual void OnRoundEnd(int roundArrayIndex) { }

	public void OnStartHookTriggeredCallback(HookCondition condition, object metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

