namespace Assets.Scripts.Simulation.MapEditorBehaviors;

public class PropManager : RootBehavior
{
	[CompilerGenerated]
	private sealed class <GetMapProps>d__23 : IEnumerable<Prop>, IEnumerable, IEnumerator<Prop>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Prop <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public PropManager <>4__this; //Field offset: 0x28
		private IEnumerator<Prop> <>7__wrap1; //Field offset: 0x30

		private override Prop System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Props.Prop>.Current
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
		public <GetMapProps>d__23(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Prop> System.Collections.Generic.IEnumerable<Assets.Scripts.Simulation.Props.Prop>.GetEnumerator() { }

		[DebuggerHidden]
		private override Prop System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Props.Prop>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal sealed class CreatePropDelegate : MulticastDelegate
	{

		public CreatePropDelegate`1(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(PropModel def, Vector3 position, int inputIndex, int groupLayer, PropSaveDataModel loadingSaveData, float rotation, bool playPlacementEffects, int customModelPropIndex, bool triggerPreviewAnimator, PositionalData positionalData, float heightOffset, bool forceShow, bool isCustomProp, AsyncCallback callback, object object) { }

		public override T EndInvoke(IAsyncResult result) { }

		public override T Invoke(PropModel def, Vector3 position, int inputIndex = -1, int groupLayer = -1, PropSaveDataModel loadingSaveData = null, float rotation = 180, bool playPlacementEffects = false, int customModelPropIndex = -1, bool triggerPreviewAnimator = false, PositionalData positionalData = null, float heightOffset = 0, bool forceShow = false, bool isCustomProp = false) { }

	}


	private bool GameTypeIsMapEditor
	{
		private get { } //Length: 44
	}

	private static bool IsLoadedSave
	{
		private get { } //Length: 72
	}

	private bool SelectedModeIsMapEditor
	{
		private get { } //Length: 103
	}

	public PropManager() { }

	public void Activate(Vector2 location, ref PropModel model) { }

	public bool CheckLocation(Vector2 location, int inputId, PropModel propModel) { }

	public void CreatePlacementEffectAt(Vector3 pos, float lifespan) { }

	private void CreatePowers() { }

	private void CreatePowerTower(PowerModel powerModel, Vector2 position) { }

	public TProp CreateProp(PropModel def, Vector3 position, int inputIndex = -1, int groupLayer = -1, PropSaveDataModel loadingSaveData = null, float rotation = 180, bool playPlacementEffects = false, int customModelPropIndex = -1, bool triggerPreviewAnimator = false, PositionalData positionalData = null, float heightOffset = 0, bool forceShow = false, bool isCustomProp = false) { }

	private void CreatePropFromCustomModelData(MapEditorPropDataModel propData, bool playPlacementEffects = false, int customModelPropIndex = -1) { }

	public void CreatePropFromCustomModelDataIndex(int index) { }

	private void CreateProps(bool playPlacementEffects) { }

	private void CreateTowerFromCustomModelData(MapEditorTowerDataModel towerData, int customMapTowerIndexId, bool playPlacementEffects = false) { }

	public void CreateTowerFromCustomModelDataIndex(int customMapTowerIndexId) { }

	private void CreateTowers(bool playPlacementEffects) { }

	public void DestroyProp(Prop prop, bool playSellEffect) { }

	private bool get_GameTypeIsMapEditor() { }

	private static bool get_IsLoadedSave() { }

	private bool get_SelectedModeIsMapEditor() { }

	public PropModel GetMapPropModelFromId(int id) { }

	[IteratorStateMachine(typeof(<GetMapProps>d__23))]
	public IEnumerable<Prop> GetMapProps() { }

	public PropModel GetScriptablePropModelFromId(string name) { }

	private float GetTowerHeight(MapEditorTowerDataModel towerData, Area areaOn) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void OnInitialised(bool isRestart) { }

	public void OnReloadFromCheckpoint() { }

	public void OnToggleMapEditorPropVisibility(int propCategoryIndex, bool isVisible, bool isSpecialEffectPropLayer) { }

	public void SellProp(Prop prop, int inputIndex, bool playSellEffect) { }

	public bool TryGetPropFromId(ObjectId id, out Prop foundProp) { }

}

