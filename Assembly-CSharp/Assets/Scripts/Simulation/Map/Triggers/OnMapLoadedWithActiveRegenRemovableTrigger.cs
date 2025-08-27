namespace Assets.Scripts.Simulation.Map.Triggers;

public class OnMapLoadedWithActiveRegenRemovableTrigger : MapTrigger
{
	private OnMapLoadedWithActiveRegenRemovableTriggerModel mapLoadedTriggerModel; //Field offset: 0x80

	public OnMapLoadedWithActiveRegenRemovableTrigger() { }

	public virtual MapEventTriggerSaveData GetSaveData() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void SetSaveData(MapEventTriggerSaveData saveData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

