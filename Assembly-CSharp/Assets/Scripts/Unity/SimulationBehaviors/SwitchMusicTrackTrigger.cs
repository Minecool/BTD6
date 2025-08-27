namespace Assets.Scripts.Unity.SimulationBehaviors;

public class SwitchMusicTrackTrigger : SimulationTriggerBehavior
{
	public string musicId; //Field offset: 0x20

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 105
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public SwitchMusicTrackTrigger() { }

	public virtual SimulationBehaviorModel get_Def() { }

	public virtual string get_Type() { }

}

