namespace Assets.Scripts.Simulation.Artifacts.Behaviors;

public class CatsMeowBehavior : ItemArtifactBehavior
{
	public CatsMeowBehaviorModel catsMeowBehaviorModel; //Field offset: 0x78
	private int lastActivatedAt; //Field offset: 0x80

	public CatsMeowBehavior() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void OnBossRushDashEndPost() { }

	protected virtual void OnDestroy() { }

	public void OnRoundEnd(int round) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

