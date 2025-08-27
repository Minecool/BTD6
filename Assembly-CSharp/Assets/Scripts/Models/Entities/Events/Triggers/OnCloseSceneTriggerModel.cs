namespace Assets.Scripts.Models.Entities.Events.Triggers;

[Implementation(typeof(OnCloseSceneTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class OnCloseSceneTriggerModel : EntityTriggerModel
{
	[SceneName]
	public string sceneName; //Field offset: 0x38

	public OnCloseSceneTriggerModel(string name, string sceneName) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

