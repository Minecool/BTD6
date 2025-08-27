namespace Assets.Scripts.Unity.SimulationBehaviors;

public class HighlightAbilitiesOnTrigger : SimulationBehavior
{
	public string triggerId; //Field offset: 0x18
	public string abilityIds; //Field offset: 0x20

	public virtual Model Model
	{
		 get { } //Length: 134
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public HighlightAbilitiesOnTrigger() { }

	public HighlightAbilitiesOnTrigger(string triggerId, string abilityIds) { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

