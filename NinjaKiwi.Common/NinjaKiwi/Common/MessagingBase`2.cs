namespace NinjaKiwi.Common;

public abstract class MessagingBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public T callback; //Field offset: 0x0

		public <>c__DisplayClass16_0() { }

		internal void <ListenWhileAlive>b__0() { }

		internal void <ListenWhileAlive>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public T callback; //Field offset: 0x0

		public <>c__DisplayClass17_0() { }

		internal void <ListenWhileActive>b__0() { }

		internal void <ListenWhileActive>b__1() { }

	}

	[Flags]
	internal enum Warn
	{
		None = 0,
		IfAlreadyRegistered = 1,
		IfAlreadyUnregistered = 2,
		IfUnityObjectDead = 4,
		Always = -1,
	}

	private static TBase _instance; //Field offset: 0x0
	private T _trigger; //Field offset: 0x0
	private int unityEngineObjectCount; //Field offset: 0x0

	private bool HasUnityEngineObjectTargets
	{
		private get { } //Length: 8
	}

	private static TBase instance
	{
		private get { } //Length: 241
	}

	private T trigger
	{
		private get { } //Length: 5
		private set { } //Length: 204
	}

	public static T Trigger
	{
		 get { } //Length: 116
	}

	private T TriggerInternal
	{
		private get { } //Length: 532
	}

	protected override Warn<T, TBase> WarningMode
	{
		 get { } //Length: 6
	}

	protected MessagingBase`2() { }

	protected void Cleanup() { }

	private bool get_HasUnityEngineObjectTargets() { }

	private static TBase get_instance() { }

	private T get_trigger() { }

	public static T get_Trigger() { }

	private T get_TriggerInternal() { }

	protected override Warn<T, TBase> get_WarningMode() { }

	private static bool HasRegistered(Delegate trigger, Delegate d) { }

	public static void ListenWhileActive(GameObject gameObject, T callback) { }

	public static void ListenWhileAlive(GameObject gameObject, T callback) { }

	public static void Register(T callback) { }

	private void RegisterInternal(T callback) { }

	private void set_trigger(T value) { }

	protected override void StartTracking() { }

	protected override void StopTracking() { }

	public static void Unregister(T callback) { }

	private void UnregisterInternal(T callback) { }

}

