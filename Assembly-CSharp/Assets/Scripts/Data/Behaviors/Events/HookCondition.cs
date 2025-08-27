namespace Assets.Scripts.Data.Behaviors.Events;

[CreateAssetMenu(fileName = "HookCondition", menuName = "BTD6/Behaviors/Simulations/HookCondition")]
public class HookCondition : EntityEvent
{
	public EntityTrigger[] eventTriggers; //Field offset: 0x50
	public EntityAction[] eventActions; //Field offset: 0x58

	public virtual Model Model
	{
		 get { } //Length: 225
	}

	public HookCondition() { }

	public virtual Model get_Model() { }

}

