namespace Assets.Scripts.Simulation.Track;

public class CustomRemoveable : Removeable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<LayerData> <>9__18_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <RequiresMapRedraw>b__18_0(LayerData layerData) { }

	}

	public CustomRemoveableModel behaviorModel; //Field offset: 0x160
	public List<AreaModel> areaModelsToSpawnOnActivate; //Field offset: 0x168
	private bool waitingForOnTriggerAnimationFxEnd; //Field offset: 0x170
	private bool waitingForOnTriggerAnimation; //Field offset: 0x171
	private int framesToWaitForPropAnimationsEnd; //Field offset: 0x174
	private int framesToWait; //Field offset: 0x178

	private LayerData[] OnHideLayerData
	{
		private get { } //Length: 33
	}

	private LayerData[] OnShowLayerData
	{
		private get { } //Length: 33
	}

	private LayerData[] OnTriggerLayerData
	{
		private get { } //Length: 33
	}

	public CustomRemoveable() { }

	private bool ContainsCategoryIndex(LayerData[] removableLayersData, LayerType layerType, int categoryLayerIndex) { }

	private LayerData[] get_OnHideLayerData() { }

	private LayerData[] get_OnShowLayerData() { }

	private LayerData[] get_OnTriggerLayerData() { }

	public override void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public bool OnLoadTriggered() { }

	private void OnTriggerAnimationElapsedEndEvent() { }

	private void OnTriggerAnimationElapsedEvent() { }

	public void OnTriggerRemoveRemoveable() { }

	public void Process(int elapsed) { }

	private bool RequiresMapRedraw(LayerData[] layersData) { }

	public override void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

