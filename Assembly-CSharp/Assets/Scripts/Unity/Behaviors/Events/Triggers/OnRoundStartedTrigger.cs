namespace Assets.Scripts.Unity.Behaviors.Events.Triggers;

public class OnRoundStartedTrigger : EntityTrigger
{
	[SerializeField]
	public int onRound; //Field offset: 0x18
	[SerializeField]
	public int everyXRounds; //Field offset: 0x1C

	public virtual Model Model
	{
		 get { } //Length: 111
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public OnRoundStartedTrigger() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

