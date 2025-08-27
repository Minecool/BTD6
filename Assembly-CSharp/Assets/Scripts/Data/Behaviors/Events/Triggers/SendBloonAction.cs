namespace Assets.Scripts.Data.Behaviors.Events.Triggers;

public class SendBloonAction : EntityAction
{
	[SerializeField]
	public string bloonId; //Field offset: 0x28
	[SerializeField]
	public bool camo; //Field offset: 0x30
	[SerializeField]
	public bool regrow; //Field offset: 0x31
	[SerializeField]
	public bool fortified; //Field offset: 0x32

	public virtual Model Model
	{
		 get { } //Length: 153
	}

	public SendBloonAction() { }

	public virtual Model get_Model() { }

}

