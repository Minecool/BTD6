namespace Assets.Scripts.Data.Behaviors.Events.Triggers;

public class OnBloonLeakedTrigger : EntityTrigger
{
	[SerializeField]
	public String[] bloonIds; //Field offset: 0x28
	[SerializeField]
	public bool camoOnly; //Field offset: 0x30
	[SerializeField]
	public bool regrowOnly; //Field offset: 0x31
	[SerializeField]
	public bool fortifiedOnly; //Field offset: 0x32
	[SerializeField]
	public bool moabOnly; //Field offset: 0x33
	[SerializeField]
	public bool inverseChecks; //Field offset: 0x34

	public virtual Model Model
	{
		 get { } //Length: 180
	}

	public OnBloonLeakedTrigger() { }

	public virtual Model get_Model() { }

}

