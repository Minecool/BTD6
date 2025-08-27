namespace Assets.Scripts.Data.Behaviors.Events.Actions;

public class DamageBloonsAction : EntityAction
{
	[SerializeField]
	public int damage; //Field offset: 0x28
	[SerializeField]
	public float range; //Field offset: 0x2C
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
		 get { } //Length: 205
	}

	public DamageBloonsAction() { }

	public virtual Model get_Model() { }

}

