namespace Assets.Scripts.Unity.Behaviors.Events.Actions;

public class DamageBloonsAction : EntityAction
{
	[SerializeField]
	public int damage; //Field offset: 0x18
	[SerializeField]
	public float range; //Field offset: 0x1C
	[SerializeField]
	public String[] bloonIds; //Field offset: 0x20
	[SerializeField]
	public bool camoOnly; //Field offset: 0x28
	[SerializeField]
	public bool regrowOnly; //Field offset: 0x29
	[SerializeField]
	public bool fortifiedOnly; //Field offset: 0x2A
	[SerializeField]
	public bool moabOnly; //Field offset: 0x2B
	[SerializeField]
	public bool inverseChecks; //Field offset: 0x2C

	public virtual Model Model
	{
		 get { } //Length: 205
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public DamageBloonsAction() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

