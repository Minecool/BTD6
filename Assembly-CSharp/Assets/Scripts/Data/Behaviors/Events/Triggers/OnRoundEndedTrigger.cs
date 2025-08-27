namespace Assets.Scripts.Data.Behaviors.Events.Triggers;

public class OnRoundEndedTrigger : EntityTrigger
{
	[SerializeField]
	public int onRound; //Field offset: 0x28
	[SerializeField]
	public int everyXRounds; //Field offset: 0x2C

	public virtual Model Model
	{
		 get { } //Length: 111
	}

	public OnRoundEndedTrigger() { }

	public virtual Model get_Model() { }

}

