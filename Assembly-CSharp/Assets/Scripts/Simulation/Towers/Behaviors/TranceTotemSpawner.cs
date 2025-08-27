namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class TranceTotemSpawner : TowerBehavior
{
	[CompilerGenerated]
	private sealed class <GetAdditionalDisplayMeshes>d__23 : IEnumerable<Mesh>, IEnumerable, IEnumerator<Mesh>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Mesh <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private TowerModel towerModel; //Field offset: 0x28
		public TowerModel <>3__towerModel; //Field offset: 0x30
		public TranceTotemSpawner <>4__this; //Field offset: 0x38

		private override Mesh System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Display.Mesh>.Current
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
		public <GetAdditionalDisplayMeshes>d__23(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Mesh> System.Collections.Generic.IEnumerable<Assets.Scripts.Simulation.Display.Mesh>.GetEnumerator() { }

		[DebuggerHidden]
		private override Mesh System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Display.Mesh>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public TranceTotemSpawnerModel tranceTotemSpawnerModel; //Field offset: 0x68
	private bool selectTargetModeActive; //Field offset: 0x70
	private int lastSwapAt; //Field offset: 0x74
	private Vector2 targetPosition; //Field offset: 0x78
	private Tower activeSubtower; //Field offset: 0x80
	private bool shouldSpawnTotem; //Field offset: 0x88
	private readonly List<TimedMutator> mutatorsToRemoveList; //Field offset: 0x90
	private TSMInfoModel newInfo; //Field offset: 0x98

	public TranceTotemSpawner() { }

	public virtual void ApplyCustomInputData(CustomInputData data) { }

	private void CreateSubtower() { }

	[IteratorStateMachine(typeof(<GetAdditionalDisplayMeshes>d__23))]
	public virtual IEnumerable<Mesh> GetAdditionalDisplayMeshes(TowerModel towerModel, Vector3 position, bool isFromHover) { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual string GetTowerBehaviorCustomInputClass(string buttonId) { }

	public virtual object GetTowerBehaviorCustomInputData(string buttonId) { }

	public virtual void GetTsmThemeInfo(out TSMInfoModel info, out string infoId) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void OnPlace(bool playPlacementEffects) { }

	public virtual void OnRoundComplete(int roundArrayIndex) { }

	public virtual void OnTsmThemeAction(string themeId, string buttonId, TSMInfoModel info) { }

	public virtual void OnUpgraded(int pathUpgraded) { }

	public void Process(int elapsed) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	private void SyncMutators(Tower towerToSync) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

