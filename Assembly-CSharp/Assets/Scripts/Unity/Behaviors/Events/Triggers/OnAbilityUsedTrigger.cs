namespace Assets.Scripts.Unity.Behaviors.Events.Triggers;

public class OnAbilityUsedTrigger : EntityTrigger
{
	public String[] towerIds; //Field offset: 0x18
	public String[] abilityIds; //Field offset: 0x20

	public virtual Model Model
	{
		 get { } //Length: 113
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public OnAbilityUsedTrigger() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

