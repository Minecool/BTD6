namespace Assets.Scripts.Unity.Behaviors.Events.Actions;

public class DestroyTowersAction : EntityAction
{
	public float range; //Field offset: 0x18
	public string towerId; //Field offset: 0x20
	public bool triggerEffect; //Field offset: 0x28
	public Effect effectOnTrigger; //Field offset: 0x30

	public virtual Model Model
	{
		 get { } //Length: 171
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public DestroyTowersAction() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

