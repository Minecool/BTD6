namespace Assets.Scripts.Unity.Behaviors.Events.Actions;

public class SendBloonAction : EntityAction
{
	[SerializeField]
	public string bloonId; //Field offset: 0x18
	[SerializeField]
	public bool camo; //Field offset: 0x20
	[SerializeField]
	public bool regrow; //Field offset: 0x21
	[SerializeField]
	public bool fortified; //Field offset: 0x22
	[SerializeField]
	public float startDist; //Field offset: 0x24

	public virtual Model Model
	{
		 get { } //Length: 174
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public SendBloonAction() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

