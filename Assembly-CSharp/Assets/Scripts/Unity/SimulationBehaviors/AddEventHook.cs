namespace Assets.Scripts.Unity.SimulationBehaviors;

public class AddEventHook : SimulationBehavior
{
	public string hookId; //Field offset: 0x18
	public bool requireAllTriggersWithinRound; //Field offset: 0x20
	public bool isAnalyticsDisabled; //Field offset: 0x21
	[SerializeReference]
	public HookCondition onHookStartCondition; //Field offset: 0x28
	[SerializeReference]
	public HookCondition[] onHookEndConditions; //Field offset: 0x30

	public virtual Model Model
	{
		 get { } //Length: 297
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public AddEventHook() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

