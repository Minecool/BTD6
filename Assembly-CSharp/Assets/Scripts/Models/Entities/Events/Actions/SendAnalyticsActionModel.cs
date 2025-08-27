namespace Assets.Scripts.Models.Entities.Events.Actions;

[Implementation(typeof(SendAnalyticsAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SendAnalyticsActionModel : EntityActionModel
{
	public string analyticsId; //Field offset: 0x38

	public SendAnalyticsActionModel(string analyticsId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

