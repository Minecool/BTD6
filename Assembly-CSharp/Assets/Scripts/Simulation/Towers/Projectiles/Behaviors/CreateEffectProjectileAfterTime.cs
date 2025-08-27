namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class CreateEffectProjectileAfterTime : ProjectileBehaviorOnEmit
{
	private CreateEffectProjectileAfterTimeModel createEffectProjectileAfterTimeModel; //Field offset: 0x68
	private int countFrom; //Field offset: 0x70
	private int timeFrames; //Field offset: 0x74

	public CreateEffectProjectileAfterTime() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnEmit() { }

	public void Process(int elapsed) { }

	public void SpawnEffect() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

