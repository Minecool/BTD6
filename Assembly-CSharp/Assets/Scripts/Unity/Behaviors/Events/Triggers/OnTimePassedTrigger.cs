namespace Assets.Scripts.Unity.Behaviors.Events.Triggers;

public class OnTimePassedTrigger : EntityTrigger
{
	[SerializeField]
	public float time; //Field offset: 0x18
	[SerializeField]
	public bool roundTimeOnly; //Field offset: 0x1C
	[SerializeField]
	public bool resetOnTrigger; //Field offset: 0x1D
	[SerializeField]
	public bool resetOnRoundStart; //Field offset: 0x1E

	public virtual Model Model
	{
		 get { } //Length: 152
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public OnTimePassedTrigger() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

