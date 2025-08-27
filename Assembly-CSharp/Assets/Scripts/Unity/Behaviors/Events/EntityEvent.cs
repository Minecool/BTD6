namespace Assets.Scripts.Unity.Behaviors.Events;

public class EntityEvent : Behavior
{
	public string eventId; //Field offset: 0x18
	public EntityTrigger[] triggers; //Field offset: 0x20
	public EntityAction[] actions; //Field offset: 0x28
	public bool requiresAllTriggers; //Field offset: 0x30
	public int maxActivationLimit; //Field offset: 0x34
	public int eventEntityIndex; //Field offset: 0x38

	public virtual Model Model
	{
		 get { } //Length: 147
	}

	public EntityEvent() { }

	public virtual Model get_Model() { }

}

