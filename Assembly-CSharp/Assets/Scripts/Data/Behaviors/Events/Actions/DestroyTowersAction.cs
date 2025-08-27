namespace Assets.Scripts.Data.Behaviors.Events.Actions;

public class DestroyTowersAction : EntityAction
{
	public float range; //Field offset: 0x28
	public string towerId; //Field offset: 0x30
	public bool triggerEffect; //Field offset: 0x38
	[JsonConverter(typeof(BehaviorConverter))]
	public Effect effectOnTrigger; //Field offset: 0x40

	public virtual Model Model
	{
		 get { } //Length: 183
	}

	public DestroyTowersAction() { }

	public virtual Model get_Model() { }

}

