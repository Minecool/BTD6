namespace Assets.Scripts.Unity.SimulationBehaviors;

public class AbilityRefreshOnTrigger : SimulationBehavior
{
	public string triggerId; //Field offset: 0x18
	public String[] abilityIds; //Field offset: 0x20

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 105
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public AbilityRefreshOnTrigger() { }

	public virtual SimulationBehaviorModel get_Def() { }

	public virtual string get_Type() { }

}

