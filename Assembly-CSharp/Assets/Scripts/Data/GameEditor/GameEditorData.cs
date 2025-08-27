namespace Assets.Scripts.Data.GameEditor;

[CreateAssetMenu(fileName = "GameEditorData", menuName = "BTD6/GameEditor-GameEditorSettings", order = 1)]
public class GameEditorData : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<Type, PrefabReference>, PrefabReference> <>9__29_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal PrefabReference <GetVariableViewPrefab>b__29_1(KeyValuePair<Type, PrefabReference> kvp) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public VariableBaseViewModel vBM; //Field offset: 0x10

		public <>c__DisplayClass29_0() { }

		internal bool <GetVariableViewPrefab>b__0(KeyValuePair<Type, PrefabReference> kvp) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public Type type; //Field offset: 0x10

		public <>c__DisplayClass31_0() { }

		internal bool <TryGetDefaultGraphNodeDescriptor>b__0(GraphNodeModelDescriptor x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public Type type; //Field offset: 0x10

		public <>c__DisplayClass32_0() { }

		internal bool <GetDefaultScriptableDescriptor>b__0(GraphNodeModelDescriptor x) { }

	}

	public PrefabReference breadcrumbButtonPrefab; //Field offset: 0x18
	public PrefabReference behaviorEditableLineItemPrefab; //Field offset: 0x20
	public PrefabReference behaviorEditableListPrefab; //Field offset: 0x28
	public PrefabReference behaviorLineItemPrefab; //Field offset: 0x30
	public PrefabReference variableImagePrefab; //Field offset: 0x38
	public PrefabReference variableTogglePrefab; //Field offset: 0x40
	public PrefabReference variableInputfieldPrefab; //Field offset: 0x48
	public PrefabReference variableBehaviorPrefab; //Field offset: 0x50
	public PrefabReference variableDisplayPrefab; //Field offset: 0x58
	public PrefabReference entityViewPrefab; //Field offset: 0x60
	public PrefabReference componentViewDefaultPrefab; //Field offset: 0x68
	public PrefabReference componentViewBehaviorPrefab; //Field offset: 0x70
	public PrefabReference componentViewEntityEventPrefab; //Field offset: 0x78
	public PrefabReference componentViewGameSettingsPanelPrefab; //Field offset: 0x80
	public PrefabReference componentViewWaypointPanelPrefab; //Field offset: 0x88
	public PrefabReference gameEditorLibraryViewPrefab; //Field offset: 0x90
	public PrefabReference gameEditorBehaviorBrowserViewPrefab; //Field offset: 0x98
	public SpriteReference defaultPropIcon; //Field offset: 0xA0
	public PrefabReference defaultPropDisplay; //Field offset: 0xA8
	public ScriptableObjectReference defaultProp; //Field offset: 0xB0
	public ScriptableObjectReference defaultEventSystem; //Field offset: 0xB8
	public GraphNodeModelDescriptor[] nodeModelDescriptors; //Field offset: 0xC0
	public string assemblyFullName; //Field offset: 0xC8
	public List<ScriptableObjectReference> props; //Field offset: 0xD0
	public List<ScriptableObjectReference> eventSystems; //Field offset: 0xD8
	private Dictionary<Type, PrefabReference> variableViewPrefabs; //Field offset: 0xE0

	public Dictionary<Type, PrefabReference> VariableViewPrefabs
	{
		 get { } //Length: 529
	}

	public GameEditorData() { }

	public Dictionary<Type, PrefabReference> get_VariableViewPrefabs() { }

	public PrefabReference GetComponentView(BehaviorViewModel behaviorVM) { }

	private PrefabReference GetCustomVariableView(VariableBaseViewModel vBM) { }

	public GraphNodeModelDescriptor GetDefaultScriptableDescriptor(Type type) { }

	public PrefabReference GetVariableViewPrefab(VariableBaseViewModel vBM) { }

	public bool TryGetDefaultGraphNodeDescriptor(Type type, out GraphNodeModelDescriptor def) { }

}

