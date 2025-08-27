namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(SwitchMusicTrackTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SwitchMusicTrackTriggerModel : SimulationBehaviorModel
{
	public string triggerId; //Field offset: 0x30
	public string musicId; //Field offset: 0x38

	public SwitchMusicTrackTriggerModel(string triggerId, string musicId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

