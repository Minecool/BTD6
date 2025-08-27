namespace Unity.Services.Core.Internal;

internal class TaskAsyncOperation : AsyncOperationBase
{
	internal static TaskScheduler Scheduler; //Field offset: 0x0
	private Task m_Task; //Field offset: 0x10

	public virtual bool IsCompleted
	{
		 get { } //Length: 29
	}

	public virtual bool get_IsCompleted() { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	internal static void SetScheduler() { }

}

