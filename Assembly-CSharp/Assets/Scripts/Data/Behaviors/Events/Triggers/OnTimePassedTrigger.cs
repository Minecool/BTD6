namespace Assets.Scripts.Data.Behaviors.Events.Triggers;

public class OnTimePassedTrigger : EntityTrigger
{
	[SerializeField]
	public float time; //Field offset: 0x28
	[SerializeField]
	public bool roundTimeOnly; //Field offset: 0x2C
	[SerializeField]
	public bool resetOnTrigger; //Field offset: 0x2D
	[SerializeField]
	public bool resetOnRoundStart; //Field offset: 0x2E

	public virtual Model Model
	{
		 get { } //Length: 152
	}

	public OnTimePassedTrigger() { }

	public virtual Model get_Model() { }

}

