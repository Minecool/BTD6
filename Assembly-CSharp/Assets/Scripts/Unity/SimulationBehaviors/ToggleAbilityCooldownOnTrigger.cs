namespace Assets.Scripts.Unity.SimulationBehaviors;

public class ToggleAbilityCooldownOnTrigger : SimulationBehavior
{
	public string triggerId; //Field offset: 0x18
	public bool unpauseAtRoundEnd; //Field offset: 0x20
	public String[] abilityIds; //Field offset: 0x28

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 129
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public ToggleAbilityCooldownOnTrigger() { }

	public virtual SimulationBehaviorModel get_Def() { }

	public virtual string get_Type() { }

}

