namespace Assets.Scripts.Data.Behaviors.Events;

[CreateAssetMenu(fileName = "AddEventHook", menuName = "BTD6/Behaviors/Simulations/AddEventHook")]
public class AddEventHook : SimulationBehavior
{
	public string hookId; //Field offset: 0x30
	public bool requireAllTriggersWithinRound; //Field offset: 0x38
	public bool isAnalyticsDisabled; //Field offset: 0x39
	[SerializeField]
	public HookCondition onHookStartCondition; //Field offset: 0x40
	[SerializeField]
	public HookCondition[] onHookEndConditions; //Field offset: 0x48

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 297
	}

	public AddEventHook() { }

	public virtual SimulationBehaviorModel get_Def() { }

}

