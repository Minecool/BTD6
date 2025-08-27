namespace UnityEngine;

[AsyncMethodBuilder(typeof(AwaitableAsyncMethodBuilder))]
[NativeHeader("Runtime/Mono/DelayedCallAwaitable.h")]
[NativeHeader("Runtime/Mono/Awaitable.h")]
[NativeHeader("Runtime/Mono/AsyncOperationAwaitable.h")]
public class Awaitable : IEnumerator
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Object> <>9__26_0; //Field offset: 0x8
		public static Func<Awaitable> <>9__76_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal ObjectPool<Awaitable> <.cctor>b__76_0() { }

		internal Awaitable <.cctor>b__76_1() { }

		internal void <WireupCancellation>b__26_0(object coroutine) { }

	}

	private struct AwaitableAndFrameIndex
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private readonly Awaitable <Awaitable>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private readonly int <FrameIndex>k__BackingField; //Field offset: 0x8

		public Awaitable Awaitable
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 4
		}

		public int FrameIndex
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 4
		}

		[CompilerGenerated]
		[IsReadOnly]
		public Awaitable get_Awaitable() { }

		[CompilerGenerated]
		[IsReadOnly]
		public int get_FrameIndex() { }

	}

	[ExcludeFromDocs]
	internal struct AwaitableAsyncMethodBuilder
	{
		private interface IStateMachineBox : IDisposable
		{

		}

		private IStateMachineBox _stateMachineBox; //Field offset: 0x0
		private Awaitable _resultingCoroutine; //Field offset: 0x8

	}

	[IsReadOnly]
	private struct AwaitableHandle
	{
		public static AwaitableHandle ManagedHandle; //Field offset: 0x0
		public static AwaitableHandle NullHandle; //Field offset: 0x8
		private readonly IntPtr _handle; //Field offset: 0x0

		public bool IsManaged
		{
			 get { } //Length: 90
		}

		public bool IsNull
		{
			 get { } //Length: 8
		}

		private static AwaitableHandle() { }

		public AwaitableHandle(IntPtr handle) { }

		public bool get_IsManaged() { }

		public bool get_IsNull() { }

		public static IntPtr op_Implicit(AwaitableHandle handle) { }

		public static AwaitableHandle op_Implicit(IntPtr handle) { }

	}

	[ExcludeFromDocs]
	internal struct Awaiter : INotifyCompletion
	{
		private readonly Awaitable _awaited; //Field offset: 0x0

		public bool IsCompleted
		{
			 get { } //Length: 28
		}

		internal Awaiter(Awaitable awaited) { }

		public bool get_IsCompleted() { }

		public void GetResult() { }

		public override void OnCompleted(Action continuation) { }

	}

	public enum AwaiterCompletionThreadAffinity
	{
		None = 0,
		MainThread = 1,
		BackgroundThread = 2,
	}

	private class DoubleBufferedAwaitableList
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			public Awaitable item; //Field offset: 0x10

			public <>c__DisplayClass4_0() { }

			internal bool <Remove>b__0(AwaitableAndFrameIndex x) { }

		}

		private List<AwaitableAndFrameIndex> _awaitables; //Field offset: 0x10
		private List<AwaitableAndFrameIndex> _scratch; //Field offset: 0x18

		public DoubleBufferedAwaitableList() { }

		public void Clear() { }

		public void Remove(Awaitable item) { }

		public void SwapAndComplete() { }

	}

	private static readonly ThreadLocal<ObjectPool`1<Awaitable>> _pool; //Field offset: 0x0
	private static bool _nextFrameAndEndOfFrameWiredUp; //Field offset: 0x8
	private static CancellationTokenRegistration _nextFrameAndEndOfFrameWiredUpCTRegistration; //Field offset: 0x10
	private static readonly DoubleBufferedAwaitableList _nextFrameAwaitables; //Field offset: 0x28
	private static readonly DoubleBufferedAwaitableList _endOfFrameAwaitables; //Field offset: 0x30
	private static SynchronizationContext _synchronizationContext; //Field offset: 0x38
	private static int _mainThreadId; //Field offset: 0x40
	private SpinLock _spinLock; //Field offset: 0x10
	private AwaitableHandle _handle; //Field offset: 0x18
	private ExceptionDispatchInfo _exceptionToRethrow; //Field offset: 0x20
	private bool _managedAwaitableDone; //Field offset: 0x28
	private AwaiterCompletionThreadAffinity _completionThreadAffinity; //Field offset: 0x2C
	private Action _continuation; //Field offset: 0x30
	private Nullable<CancellationTokenRegistration> _cancelTokenRegistration; //Field offset: 0x38
	private DoubleBufferedAwaitableList _managedCompletionQueue; //Field offset: 0x58

	public bool IsCompleted
	{
		 get { } //Length: 535
	}

	private bool IsCompletedNoLock
	{
		private get { } //Length: 317
	}

	internal bool IsDettachedOrCompleted
	{
		internal get { } //Length: 569
	}

	private bool IsLogicallyCompletedNoLock
	{
		private get { } //Length: 269
	}

	private override object System.Collections.IEnumerator.Current
	{
		private get { } //Length: 3
	}

	private static Awaitable() { }

	private Awaitable() { }

	[FreeFunction("Scripting::Awaitables::AttachManagedWrapper", IsThreadSafe = True)]
	private static void AttachManagedGCHandleToNativeAwaitable(IntPtr nativeAwaitable, UIntPtr gcHandle) { }

	public void Cancel() { }

	[FreeFunction("Scripting::Awaitables::Cancel", IsThreadSafe = True)]
	private static void CancelNativeAwaitable(IntPtr nativeAwaitable) { }

	private AwaitableHandle CheckPointerValidity() { }

	private static void DoRunContinuationOnSynchonizationContext(object continuation) { }

	public static Awaitable FromAsyncOperation(AsyncOperation op, CancellationToken cancellationToken = null) { }

	[FreeFunction("Scripting::Awaitables::FromAsyncOperation", ThrowsException = True)]
	private static IntPtr FromAsyncOperationInternal(IntPtr asyncOperation) { }

	private static Awaitable FromNativeAwaitableHandle(IntPtr nativeHandle, CancellationToken cancellationToken) { }

	public bool get_IsCompleted() { }

	private bool get_IsCompletedNoLock() { }

	internal bool get_IsDettachedOrCompleted() { }

	private bool get_IsLogicallyCompletedNoLock() { }

	[ExcludeFromDocs]
	public Awaiter GetAwaiter() { }

	[FreeFunction("Scripting::Awaitables::IsCompleted", IsThreadSafe = True)]
	private static int IsNativeAwaitableCompleted(IntPtr nativeAwaitable) { }

	private static bool MatchCompletionThreadAffinity(AwaiterCompletionThreadAffinity awaiterCompletionThreadAffinity) { }

	[RequiredByNativeCode]
	private static void OnDelayedCallManagerCleared() { }

	[RequiredByNativeCode]
	private static void OnEndOfFrame() { }

	[RequiredByNativeCode]
	private static void OnUpdate() { }

	internal void PropagateExceptionAndRelease() { }

	internal void RaiseManagedCompletion() { }

	internal void RaiseManagedCompletion(Exception exception) { }

	[FreeFunction("Scripting::Awaitables::Release", IsThreadSafe = True)]
	private static void ReleaseNativeAwaitable(IntPtr nativeAwaitable) { }

	[RequiredByNativeCode(GenerateProxy = True)]
	private void RunContinuation() { }

	private void RunOrScheduleContinuation(AwaiterCompletionThreadAffinity awaiterCompletionThreadAffinity, Action continuation) { }

	internal void SetContinuation(Action continuation) { }

	[RequiredByNativeCode(GenerateProxy = True)]
	private void SetExceptionFromNative(Exception ex) { }

	internal static void SetSynchronizationContext(UnitySynchronizationContext synchronizationContext) { }

	private override object System.Collections.IEnumerator.get_Current() { }

	private override bool System.Collections.IEnumerator.MoveNext() { }

	private override void System.Collections.IEnumerator.Reset() { }

	private static void WireupCancellation(Awaitable awaitable, CancellationToken cancellationToken) { }

}

