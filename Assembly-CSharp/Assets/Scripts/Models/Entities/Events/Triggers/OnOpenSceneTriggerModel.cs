namespace Assets.Scripts.Models.Entities.Events.Triggers;

[Implementation(typeof(OnOpenSceneTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class OnOpenSceneTriggerModel : EntityTriggerModel
{
	[SceneName]
	public string sceneName; //Field offset: 0x38

	public OnOpenSceneTriggerModel(string name, string sceneName) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

