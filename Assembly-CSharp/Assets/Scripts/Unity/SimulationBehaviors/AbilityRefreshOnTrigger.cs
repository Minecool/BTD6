namespace Assets.Scripts.Unity.SimulationBehaviors;

public class AbilityRefreshOnTrigger : SimulationBehavior
{
	public string triggerId; //Field offset: 0x18
	public String[] abilityIds; //Field offset: 0x20

	public virtual Model Model
	{
		 get { } //Length: 105
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public AbilityRefreshOnTrigger() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

