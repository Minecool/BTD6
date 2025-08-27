namespace Assets.Scripts.Data.Behaviors.Events.Triggers;

public class GiveTowerCountAction : EntityAction
{
	[SerializeField]
	public int amount; //Field offset: 0x28
	[SerializeField]
	public string towerId; //Field offset: 0x30

	public virtual Model Model
	{
		 get { } //Length: 112
	}

	public GiveTowerCountAction() { }

	public virtual Model get_Model() { }

}

