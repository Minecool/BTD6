namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class RedirectBloonSpawning : SimulationBehavior
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public Vector2 origin; //Field offset: 0x10

		public <>c__DisplayClass13_0() { }

		internal float <SetBloonSpawnOrigin>b__0(PathSegment segment) { }

	}

	public RedirectBloonSpawningModel redirectBloonSpawningModel; //Field offset: 0x58
	private int startedAt; //Field offset: 0x60
	private PathSegment origin; //Field offset: 0x68
	private Entity portalDisplay; //Field offset: 0x70
	public int roundsRemaining; //Field offset: 0x78

	public RedirectBloonSpawning() { }

	public virtual PathSegment BloonSpawnOrigin() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void OnRoundEnd(int roundArrayIndex) { }

	private void Process(int elapsed) { }

	public void SetBloonSpawnOrigin(PathSegment origin, float effectRotation = 0) { }

	public void SetBloonSpawnOrigin(Vector2 origin, float effectRotation = 0) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

