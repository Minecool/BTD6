namespace Assets.Scripts.Simulation.Map.Triggers;

public abstract class MapTrigger : RootBehavior
{
	public MapTriggerModel triggerModel; //Field offset: 0x58
	public Action Triggered; //Field offset: 0x60
	public bool hasTriggered; //Field offset: 0x68
	public int triggerCount; //Field offset: 0x6C
	public Action SpecialCheckEvent; //Field offset: 0x70
	public MapEvent mapEvent; //Field offset: 0x78

	protected MapTrigger() { }

	public override void CheckIfTriggered() { }

	public override void DeInit() { }

	public override MapEventTriggerSaveData GetSaveData() { }

	public override void Init() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void JustTriggered() { }

	public override void SetSaveData(MapEventTriggerSaveData saveData) { }

	public void TriggerSpecialCheck() { }

}

