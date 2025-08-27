namespace Assets.Scripts.Unity.SimulationBehaviors;

public class HighlightAbilitiesOnTrigger : SimulationBehavior
{
	public string triggerId; //Field offset: 0x18
	public string abilityIds; //Field offset: 0x20

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 134
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public HighlightAbilitiesOnTrigger() { }

	public HighlightAbilitiesOnTrigger(string triggerId, string abilityIds) { }

	public virtual SimulationBehaviorModel get_Def() { }

	public virtual string get_Type() { }

}

