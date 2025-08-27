namespace Assets.Scripts.Unity.Behaviors.Events.Actions;

public class GiveTowerCountAction : EntityAction
{
	[SerializeField]
	public int amount; //Field offset: 0x18
	[SerializeField]
	public string towerId; //Field offset: 0x20

	public virtual Model Model
	{
		 get { } //Length: 112
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public GiveTowerCountAction() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

