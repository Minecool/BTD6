namespace Assets.Scripts.Simulation.Map.Triggers;

public class MapEvent : RootBehavior
{
	public List<MapTrigger> triggers; //Field offset: 0x58
	public List<MapAction> actions; //Field offset: 0x60
	public MapEventModel mapEventModel; //Field offset: 0x68
	private int triggerCount; //Field offset: 0x70
	private bool isActive; //Field offset: 0x74

	public bool IsActive
	{
		 get { } //Length: 5
	}

	public MapEvent() { }

	public void CheckIfTriggered(bool loadSave) { }

	public void DeInit() { }

	public bool get_IsActive() { }

	public MapEventSaveData GetSaveData() { }

	private int GetTriggerCount() { }

	public void Init() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private bool IsTriggered() { }

	private void PostTrigger(int triggerCount, bool loadSave) { }

	private void PreTrigger() { }

	public void SetActive(bool active) { }

	public void SetSaveData(MapEventSaveData saveData) { }

	public void SpecialCheckIfTriggered() { }

	private void Trigger() { }

	public void TriggerTriggered() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

