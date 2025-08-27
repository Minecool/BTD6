namespace Assets.Scripts.Data.Behaviors.Events.Triggers;

public class OnAbilityUsedTrigger : EntityTrigger
{
	public String[] towerIds; //Field offset: 0x28
	public String[] abilityIds; //Field offset: 0x30

	public virtual Model Model
	{
		 get { } //Length: 113
	}

	public OnAbilityUsedTrigger() { }

	public virtual Model get_Model() { }

}

