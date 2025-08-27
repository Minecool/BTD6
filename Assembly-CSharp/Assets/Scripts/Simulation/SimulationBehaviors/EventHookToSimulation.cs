namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class EventHookToSimulation
{
	private readonly AddEventHook eventHook; //Field offset: 0x10
	private readonly HookConditionModel startHook; //Field offset: 0x18
	private readonly List<HookConditionModel> endHooks; //Field offset: 0x20
	public int startHookRoundIndex; //Field offset: 0x28
	public int endHookRoundIndex; //Field offset: 0x2C

	public AddEventHookModel AddEventHookModel
	{
		 get { } //Length: 27
	}

	public List<HookConditionModel> EndHooks
	{
		 get { } //Length: 5
	}

	public string EventId
	{
		 get { } //Length: 36
	}

	public HookConditionModel StartHook
	{
		 get { } //Length: 5
	}

	public EventHookToSimulation(AddEventHook eventHook, HookConditionModel startHook, List<HookConditionModel> endHooks) { }

	public AddEventHookModel get_AddEventHookModel() { }

	public List<HookConditionModel> get_EndHooks() { }

	public string get_EventId() { }

	public HookConditionModel get_StartHook() { }

	public int GetEndHookIndex(HookConditionModel hookCondition) { }

	public void SetEndHookRound(int round) { }

	public void SetStartHookRound(int round) { }

}

