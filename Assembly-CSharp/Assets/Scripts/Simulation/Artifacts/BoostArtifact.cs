namespace Assets.Scripts.Simulation.Artifacts;

public class BoostArtifact : ArtifactBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static GetRangeDelegate <>9__4_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal float <Initialise>b__4_0() { }

	}

	public BoostArtifactModel boostArtifactModel; //Field offset: 0x78
	private TransformBehavior transformBehavior; //Field offset: 0x80
	private Zoned<Tower> zone; //Field offset: 0x88
	public readonly List<BoostArtifactBehavior> boostArtifactBehaviors; //Field offset: 0x90

	public BoostArtifact() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public override bool IsTowerModelAllowedInZone(TowerModel towerModel) { }

	protected virtual void OnDestroy() { }

	protected override void OnTowerEnterZone(Tower tower) { }

	protected override void OnTowerExitZone(Tower tower) { }

	private bool TowerAllowedInZone(RootBehavior behavior) { }

	private void TowerEnterZone(Tower tower) { }

	private void TowerExitZone(Tower tower) { }

}

