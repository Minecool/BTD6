namespace Assets.Scripts.Simulation.Map.Triggers;

public class OnProjectileHitTrigger : MapTrigger
{
	private OnProjectileHitTriggerModel onProjectileHitTriggerModel; //Field offset: 0x80
	private int hitCount; //Field offset: 0x88
	private MapItemVsProjectileBehavior simBehavior; //Field offset: 0x90

	public OnProjectileHitTrigger() { }

	public virtual void CheckIfTriggered() { }

	public virtual void DeInit() { }

	public virtual MapEventTriggerSaveData GetSaveData() { }

	public virtual void Init() { }

	private void OnHit() { }

	public virtual void SetSaveData(MapEventTriggerSaveData saveData) { }

}

