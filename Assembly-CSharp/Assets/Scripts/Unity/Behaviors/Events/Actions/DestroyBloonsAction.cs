namespace Assets.Scripts.Unity.Behaviors.Events.Actions;

public class DestroyBloonsAction : EntityAction
{
	[SerializeField]
	public float range; //Field offset: 0x18
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
		 get { } //Length: 199
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public DestroyBloonsAction() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

