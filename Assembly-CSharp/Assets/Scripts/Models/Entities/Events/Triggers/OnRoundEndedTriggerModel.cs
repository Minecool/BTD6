namespace Assets.Scripts.Models.Entities.Events.Triggers;

[Implementation(typeof(OnRoundEndedTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class OnRoundEndedTriggerModel : EntityTriggerModel
{
	public int onRound; //Field offset: 0x38
	public int everyXRounds; //Field offset: 0x3C

	public OnRoundEndedTriggerModel(string name, int onRound, int everyXRounds) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

