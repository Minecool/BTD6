namespace Assets.Scripts.Unity.Behaviors.Events.Actions;

public class SellTowersAction : EntityAction
{
	[SerializeField]
	public float range; //Field offset: 0x18
	[SerializeField]
	public string towerId; //Field offset: 0x20

	public virtual Model Model
	{
		 get { } //Length: 114
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public SellTowersAction() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

