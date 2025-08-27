namespace System.Threading;

public class ReaderWriterLockSlim : IDisposable
{
	private struct TimeoutTracker
	{
		private int m_total; //Field offset: 0x0
		private int m_start; //Field offset: 0x4

		public bool IsExpired
		{
			 get { } //Length: 63
		}

		public int RemainingMilliseconds
		{
			 get { } //Length: 63
		}

		public TimeoutTracker(int millisecondsTimeout) { }

		public bool get_IsExpired() { }

		public int get_RemainingMilliseconds() { }

	}

	[ThreadStatic]
	private static ReaderWriterCount t_rwc; //Field offset: 0x80000000
	private static long s_nextLockID; //Field offset: 0x0
	private bool fIsReentrant; //Field offset: 0x10
	private int myLock; //Field offset: 0x14
	private uint numWriteWaiters; //Field offset: 0x18
	private uint numReadWaiters; //Field offset: 0x1C
	private uint numWriteUpgradeWaiters; //Field offset: 0x20
	private uint numUpgradeWaiters; //Field offset: 0x24
	private bool fNoWaiters; //Field offset: 0x28
	private int upgradeLockOwnerId; //Field offset: 0x2C
	private int writeLockOwnerId; //Field offset: 0x30
	private EventWaitHandle writeEvent; //Field offset: 0x38
	private EventWaitHandle readEvent; //Field offset: 0x40
	private EventWaitHandle upgradeEvent; //Field offset: 0x48
	private EventWaitHandle waitUpgradeEvent; //Field offset: 0x50
	private long lockID; //Field offset: 0x58
	private bool fUpgradeThreadHoldingRead; //Field offset: 0x60
	private uint owners; //Field offset: 0x64
	private bool fDisposed; //Field offset: 0x68

	public bool IsReadLockHeld
	{
		 get { } //Length: 110
	}

	public bool IsUpgradeableReadLockHeld
	{
		 get { } //Length: 158
	}

	public bool IsWriteLockHeld
	{
		 get { } //Length: 158
	}

	public int RecursiveReadCount
	{
		 get { } //Length: 105
	}

	public int RecursiveUpgradeCount
	{
		 get { } //Length: 182
	}

	public int RecursiveWriteCount
	{
		 get { } //Length: 182
	}

	public int WaitingReadCount
	{
		 get { } //Length: 4
	}

	public int WaitingUpgradeCount
	{
		 get { } //Length: 4
	}

	public int WaitingWriteCount
	{
		 get { } //Length: 4
	}

	public ReaderWriterLockSlim() { }

	public ReaderWriterLockSlim(LockRecursionPolicy recursionPolicy) { }

	private void ClearUpgraderWaiting() { }

	private void ClearWriterAcquired() { }

	private void ClearWritersWaiting() { }

	private void Dispose(bool disposing) { }

	public override void Dispose() { }

	private void EnterMyLock() { }

	private void EnterMyLockSpin() { }

	public void EnterReadLock() { }

	public void EnterUpgradeableReadLock() { }

	public void EnterWriteLock() { }

	private void ExitAndWakeUpAppropriateReadWaiters() { }

	private void ExitAndWakeUpAppropriateWaiters() { }

	private void ExitAndWakeUpAppropriateWaitersPreferringWriters() { }

	private void ExitMyLock() { }

	public void ExitReadLock() { }

	public void ExitUpgradeableReadLock() { }

	public void ExitWriteLock() { }

	public bool get_IsReadLockHeld() { }

	public bool get_IsUpgradeableReadLockHeld() { }

	public bool get_IsWriteLockHeld() { }

	public int get_RecursiveReadCount() { }

	public int get_RecursiveUpgradeCount() { }

	public int get_RecursiveWriteCount() { }

	public int get_WaitingReadCount() { }

	public int get_WaitingUpgradeCount() { }

	public int get_WaitingWriteCount() { }

	private uint GetNumReaders() { }

	private ReaderWriterCount GetThreadRWCount(bool dontAllocate) { }

	private void InitializeThreadCounts() { }

	private static bool IsRWEntryEmpty(ReaderWriterCount rwc) { }

	private bool IsRwHashEntryChanged(ReaderWriterCount lrwc) { }

	private bool IsWriterAcquired() { }

	private void LazyCreateEvent(ref EventWaitHandle waitEvent, bool makeAutoResetEvent) { }

	private void SetUpgraderWaiting() { }

	private void SetWriterAcquired() { }

	private void SetWritersWaiting() { }

	private static void SpinWait(int SpinCount) { }

	private bool TryEnterReadLock(TimeoutTracker timeout) { }

	public bool TryEnterReadLock(int millisecondsTimeout) { }

	private bool TryEnterReadLockCore(TimeoutTracker timeout) { }

	private bool TryEnterUpgradeableReadLock(TimeoutTracker timeout) { }

	public bool TryEnterUpgradeableReadLock(int millisecondsTimeout) { }

	private bool TryEnterUpgradeableReadLockCore(TimeoutTracker timeout) { }

	private bool TryEnterWriteLock(TimeoutTracker timeout) { }

	public bool TryEnterWriteLock(int millisecondsTimeout) { }

	private bool TryEnterWriteLockCore(TimeoutTracker timeout) { }

	private bool WaitOnEvent(EventWaitHandle waitEvent, ref uint numWaiters, TimeoutTracker timeout, bool isWriteWaiter) { }

}

