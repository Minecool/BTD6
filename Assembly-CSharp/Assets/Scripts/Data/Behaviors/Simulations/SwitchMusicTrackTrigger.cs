namespace Assets.Scripts.Data.Behaviors.Simulations;

[CreateAssetMenu(fileName = "NewSwitchMusicTrackTrigger", menuName = "BTD6/Behaviors/Simulations/SwitchMusicTrackTrigger")]
public class SwitchMusicTrackTrigger : SimulationBehavior
{
	public string musicId; //Field offset: 0x30
	public string triggerId; //Field offset: 0x38

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 105
	}

	public SwitchMusicTrackTrigger() { }

	public virtual SimulationBehaviorModel get_Def() { }

}

