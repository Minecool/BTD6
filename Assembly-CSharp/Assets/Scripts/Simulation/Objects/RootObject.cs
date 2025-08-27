namespace Assets.Scripts.Simulation.Objects;

[Il2CppSetOption(Option::NullChecks (1), False)]
[Il2CppSetOption(Option::ArrayBoundsChecks (2), False)]
public abstract class RootObject : IRootObject
{
	internal sealed class DestroyedEventHandler : MulticastDelegate
	{

		public DestroyedEventHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(RootObject obj, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(RootObject obj) { }

	}

	[CompilerGenerated]
	private ObjectId <Id>k__BackingField; //Field offset: 0x10
	protected Simulation Sim; //Field offset: 0x18
	private bool isPaused; //Field offset: 0x20
	private bool isDestroyed; //Field offset: 0x21
	private int pauseCount; //Field offset: 0x24
	protected bool isProcessOrderImportant; //Field offset: 0x28
	public bool processAdded; //Field offset: 0x29
	private LockList<ProcessDelegate> processInternal; //Field offset: 0x30
	private List<DestroyedEventHandler> onDestroyEvent; //Field offset: 0x38
	private bool holdUntilNextProcess; //Field offset: 0x40

	public event DestroyedEventHandler OnDestroyEvent
	{
		 add { } //Length: 220
		 remove { } //Length: 79
	}

	public event ProcessDelegate process
	{
		 add { } //Length: 214
		 remove { } //Length: 79
	}

	public override ObjectId Id
	{
		[CompilerGenerated]
		 get { } //Length: 94
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override bool IsDestroyed
	{
		 get { } //Length: 5
		 set { } //Length: 7
	}

	public override bool IsPaused
	{
		 get { } //Length: 32
		 set { } //Length: 4
	}

	public override int PauseCount
	{
		 get { } //Length: 13
		 set { } //Length: 17
	}

	protected RootObject() { }

	public void add_OnDestroyEvent(DestroyedEventHandler value) { }

	public void add_process(ProcessDelegate value) { }

	public override void Cleanup() { }

	public override void Create(Simulation sim) { }

	public override void Destroy() { }

	[CompilerGenerated]
	public override ObjectId get_Id() { }

	public override bool get_IsDestroyed() { }

	public override bool get_IsPaused() { }

	public override int get_PauseCount() { }

	protected override void OnDestroy() { }

	public void ProcessRootObject(int elapsed) { }

	public void remove_OnDestroyEvent(DestroyedEventHandler value) { }

	public void remove_process(ProcessDelegate value) { }

	[CompilerGenerated]
	public override void set_Id(ObjectId value) { }

	public override void set_IsDestroyed(bool value) { }

	public void set_IsPaused(bool value) { }

	public void set_PauseCount(int value) { }

	public void UnHold() { }

}

