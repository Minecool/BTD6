namespace Assets.Scripts.Unity.Behaviors.Events.Triggers;

public class OnRecieveSignalTrigger : EntityTrigger
{
	public String[] signalIds; //Field offset: 0x18
	public bool requireAllSignals; //Field offset: 0x20
	public int resetWaitAfterSeconds; //Field offset: 0x24
	public bool allowDuplicateFrameTriggers; //Field offset: 0x28

	public virtual Model Model
	{
		 get { } //Length: 151
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public OnRecieveSignalTrigger() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

