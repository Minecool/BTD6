namespace Assets.Scripts.Data.Behaviors.Events.Actions;

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
	[SerializeField]
	public float startingDist; //Field offset: 0x34

	public virtual Model Model
	{
		 get { } //Length: 174
	}

	public SendBloonAction() { }

	public virtual Model get_Model() { }

}

