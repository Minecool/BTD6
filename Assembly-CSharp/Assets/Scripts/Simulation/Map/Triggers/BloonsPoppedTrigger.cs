namespace Assets.Scripts.Simulation.Map.Triggers;

public class BloonsPoppedTrigger : MapTrigger
{
	private BloonsPoppedTriggerModel bloonsPoppedTriggerModel; //Field offset: 0x80
	private int bloonsAbsorbed; //Field offset: 0x88
	private int absorbingPausedAt; //Field offset: 0x8C

	public BloonsPoppedTrigger() { }

	public virtual void CheckIfTriggered() { }

	public virtual void DeInit() { }

	public virtual MapEventTriggerSaveData GetSaveData() { }

	public virtual void Init() { }

	private void OnBloonPopped(Projectile projectile, Bloon bloon, Tower tower, DamageResult damageResult) { }

	public virtual void SetSaveData(MapEventTriggerSaveData saveData) { }

}

