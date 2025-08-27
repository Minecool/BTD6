namespace Assets.Scripts.Data.Behaviors.Events.Actions;

public class SendAnalyticsAction : EntityAction
{
	public string analyticsId; //Field offset: 0x28

	public virtual Model Model
	{
		 get { } //Length: 88
	}

	public SendAnalyticsAction() { }

	public virtual Model get_Model() { }

}

