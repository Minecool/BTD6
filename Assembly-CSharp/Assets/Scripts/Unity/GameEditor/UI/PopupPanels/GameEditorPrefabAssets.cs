namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public class GameEditorPrefabAssets
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public string name; //Field offset: 0x10

		public <>c__DisplayClass18_0() { }

		internal bool <TryGetProp>b__0(ActorPrefabModelData x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public int hash; //Field offset: 0x10

		public <>c__DisplayClass19_0() { }

		internal bool <TryGetPropByHash>b__0(ActorPrefabModelData x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public string name; //Field offset: 0x10

		public <>c__DisplayClass22_0() { }

		internal bool <RetrieveUniqueName>b__0(CustomPrefabModelData entity) { }

	}

	public static GameEditorPrefabAssets instance; //Field offset: 0x0
	[CompilerGenerated]
	private List<ActorPrefabModelData> <Actors>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private List<EventSystemModelData> <Events>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private List<CustomPrefabModelData> <Waypoints>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private List<CustomPrefabModelData> <Settings>k__BackingField; //Field offset: 0x28

	public private List<ActorPrefabModelData> Actors
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private List<EventSystemModelData> Events
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private List<CustomPrefabModelData> Settings
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private List<CustomPrefabModelData> Waypoints
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public GameEditorPrefabAssets() { }

	public void AddActor(ActorPrefabModelData data) { }

	public void AddEventSystem(EventSystemModelData data) { }

	[CompilerGenerated]
	public List<ActorPrefabModelData> get_Actors() { }

	[CompilerGenerated]
	public List<EventSystemModelData> get_Events() { }

	[CompilerGenerated]
	public List<CustomPrefabModelData> get_Settings() { }

	[CompilerGenerated]
	public List<CustomPrefabModelData> get_Waypoints() { }

	public IEnumerable<CustomPrefabModelData> GetListFromType(GameEditorPrefabType prefabType) { }

	private void OnDeserializeGameEditor() { }

	public void RemoveActor(ActorPrefabModelData data) { }

	public void RemoveEventSytem(EventSystemModelData data) { }

	public string RetrieveUniqueName(GameEditorPrefabType prefabType) { }

	[CompilerGenerated]
	private void set_Actors(List<ActorPrefabModelData> value) { }

	[CompilerGenerated]
	private void set_Events(List<EventSystemModelData> value) { }

	[CompilerGenerated]
	private void set_Settings(List<CustomPrefabModelData> value) { }

	[CompilerGenerated]
	private void set_Waypoints(List<CustomPrefabModelData> value) { }

	public bool TryGetProp(string name, out Prop data) { }

	public bool TryGetPropByHash(int hash, out Prop data) { }

}

