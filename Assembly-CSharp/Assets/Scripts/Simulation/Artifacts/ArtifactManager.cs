namespace Assets.Scripts.Simulation.Artifacts;

public class ArtifactManager : RootBehavior
{
	[CompilerGenerated]
	private sealed class <GetActiveArtifactsOfType>d__8 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		public ArtifactManager <>4__this; //Field offset: 0x0
		private Enumerator<ArtifactBase> <>7__wrap1; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <GetActiveArtifactsOfType>d__8`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[DebuggerHidden]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private readonly List<ArtifactBase> activeArtifacts; //Field offset: 0x58
	private readonly Dictionary<Type, List`1<ArtifactBase>> activeArtifactsByType; //Field offset: 0x60
	private readonly Dictionary<String, Int32> towerModelStackCountsThisFrame; //Field offset: 0x68

	public ArtifactManager() { }

	public void Activate(string artifactName) { }

	public bool CanApplyMutatorToPlacementModel(BehaviorMutator mutator) { }

	public void CheatGiveAllBoostArtifacts(int tier) { }

	public void CheatGiveAllItemArtifacts(int tier) { }

	public void CheatGiveArtifact(string artifactName) { }

	public void Deactivate(string artifactName) { }

	public ArtifactBase GetActiveArtifactOfBaseId(string baseId) { }

	public List<ArtifactBase> GetActiveArtifacts() { }

	[IteratorStateMachine(typeof(<GetActiveArtifactsOfType>d__8`1))]
	public IEnumerable<T> GetActiveArtifactsOfType() { }

	public TowerModel GetModifiedPlacementTowerModel(TowerModel towerModel) { }

	public ProjectileModel GetModifiedTowerEmittedProjectileModel(ProjectileModel projectileModel, Tower tower, Weapon entityWeapon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public bool IsArtifactActive(string artifactName) { }

	public bool IsArtifactOfBaseIdActive(string baseId) { }

	public void MutatePlacementModel(TowerModel clonedTowerModel, BehaviorMutator mutator) { }

	protected virtual void OnDestroy() { }

}

