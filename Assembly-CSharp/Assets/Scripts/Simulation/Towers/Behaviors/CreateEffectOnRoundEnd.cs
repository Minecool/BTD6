namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class CreateEffectOnRoundEnd : TowerBehavior
{
	public CreateEffectOnRoundEndModel createEffectOnRoundEndModel; //Field offset: 0x68

	public CreateEffectOnRoundEnd() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void OnRoundEnd(int round) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

