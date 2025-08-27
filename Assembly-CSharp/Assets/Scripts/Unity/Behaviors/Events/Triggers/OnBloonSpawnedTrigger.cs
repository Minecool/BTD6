namespace Assets.Scripts.Unity.Behaviors.Events.Triggers;

public class OnBloonSpawnedTrigger : EntityTrigger
{
	[SerializeField]
	public String[] bloonIds; //Field offset: 0x18
	[SerializeField]
	public bool camoOnly; //Field offset: 0x20
	[SerializeField]
	public bool regrowOnly; //Field offset: 0x21
	[SerializeField]
	public bool fortifiedOnly; //Field offset: 0x22
	[SerializeField]
	public bool moabOnly; //Field offset: 0x23
	[SerializeField]
	public bool inverseChecks; //Field offset: 0x24

	public virtual Model Model
	{
		 get { } //Length: 180
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public OnBloonSpawnedTrigger() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

