namespace Assets.Scripts.Simulation.Artifacts.Behaviors;

public class RoundSkipBehavior : ItemArtifactBehavior
{
	public RoundSkipBehaviorModel roundSkipBehaviorModel; //Field offset: 0x78
	private bool hasAppliedThisFrame; //Field offset: 0x80

	public RoundSkipBehavior() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void OnCurrentRoundIncreased(int round) { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

