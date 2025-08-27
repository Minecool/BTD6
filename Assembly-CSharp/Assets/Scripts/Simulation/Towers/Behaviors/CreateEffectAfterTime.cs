namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class CreateEffectAfterTime : TowerBehavior
{
	public CreateEffectAfterTimeModel createEffectAfterTimeModel; //Field offset: 0x68
	private int lifespan; //Field offset: 0x70
	private int lastRoundTimeElapsed; //Field offset: 0x74
	private bool spawnedEffect; //Field offset: 0x78

	public CreateEffectAfterTime() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void Process(int elapsed) { }

	public void SpawnEffect() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

