namespace Assets.Scripts.Data.Behaviors.Events.Triggers;

public class OnBloonDamagedTrigger : EntityTrigger
{
	[SerializeField]
	public float range; //Field offset: 0x28
	[SerializeField]
	public String[] bloonIds; //Field offset: 0x30
	[SerializeField]
	public bool camoOnly; //Field offset: 0x38
	[SerializeField]
	public bool regrowOnly; //Field offset: 0x39
	[SerializeField]
	public bool fortifiedOnly; //Field offset: 0x3A
	[SerializeField]
	public bool moabOnly; //Field offset: 0x3B
	[SerializeField]
	public bool inverseChecks; //Field offset: 0x3C

	public virtual Model Model
	{
		 get { } //Length: 199
	}

	public OnBloonDamagedTrigger() { }

	public virtual Model get_Model() { }

}

