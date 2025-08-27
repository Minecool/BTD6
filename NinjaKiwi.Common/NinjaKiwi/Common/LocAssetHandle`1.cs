namespace NinjaKiwi.Common;

public abstract class LocAssetHandle
{
	[CompilerGenerated]
	private bool <Completed>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Task <Task>k__BackingField; //Field offset: 0x0

	public abstract T Asset
	{
		 get { } //Length: 0
	}

	public bool Completed
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public private Task Task
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	protected LocAssetHandle`1(string address) { }

	public abstract T get_Asset() { }

	[CompilerGenerated]
	public bool get_Completed() { }

	[CompilerGenerated]
	public Task get_Task() { }

	protected abstract Task Load(string address) { }

	public override void Release() { }

	[CompilerGenerated]
	protected void set_Completed(bool value) { }

	[CompilerGenerated]
	private void set_Task(Task value) { }

}

