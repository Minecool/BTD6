namespace Facepunch.Steamworks;

public class BaseSteamworks : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass41_0
	{
		public Action<T> func; //Field offset: 0x0

		public <>c__DisplayClass41_0`1() { }

		internal void <RegisterCallback>b__0(object o) { }

	}

	[CompilerGenerated]
	private uint <AppId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Networking <Networking>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Inventory <Inventory>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Workshop <Workshop>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Action OnUpdate; //Field offset: 0x30
	internal NativeInterface native; //Field offset: 0x38
	private List<CallbackHandle> CallbackHandles; //Field offset: 0x40
	private List<CallResult> CallResults; //Field offset: 0x48
	protected bool disposed; //Field offset: 0x50
	public Action<Object> OnAnyCallback; //Field offset: 0x58
	private Dictionary<Type, List`1<Action`1<Object>>> Callbacks; //Field offset: 0x60

	public internal uint AppId
	{
		[CompilerGenerated]
		 get { } //Length: 94
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	public internal Inventory Inventory
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 5
	}

	internal override bool IsGameServer
	{
		internal get { } //Length: 3
	}

	public bool IsValid
	{
		 get { } //Length: 9
	}

	public internal Networking Networking
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 5
	}

	public internal Workshop Workshop
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 5
	}

	protected BaseSteamworks(uint appId) { }

	internal List<Action`1<Object>> CallbackList(Type T) { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	[CompilerGenerated]
	public uint get_AppId() { }

	[CompilerGenerated]
	public Inventory get_Inventory() { }

	internal override bool get_IsGameServer() { }

	public bool get_IsValid() { }

	[CompilerGenerated]
	public Networking get_Networking() { }

	[CompilerGenerated]
	public Workshop get_Workshop() { }

	internal void OnCallback(T data) { }

	internal void RegisterCallback(Action<T> func) { }

	internal void RegisterCallbackHandle(CallbackHandle handle) { }

	internal void RegisterCallResult(CallResult handle) { }

	public void RunUpdateCallbacks() { }

	[CompilerGenerated]
	internal void set_AppId(uint value) { }

	[CompilerGenerated]
	internal void set_Inventory(Inventory value) { }

	[CompilerGenerated]
	internal void set_Networking(Networking value) { }

	[CompilerGenerated]
	internal void set_Workshop(Workshop value) { }

	protected void SetupCommonInterfaces() { }

	internal void UnregisterCallResult(CallResult handle) { }

	public override void Update() { }

}

