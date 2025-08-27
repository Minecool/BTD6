namespace Unity.Services.Analytics.Internal;

internal class Dispatcher : IDispatcher
{
	private readonly IWebRequestHelper m_WebRequestHelper; //Field offset: 0x10
	private readonly string m_CollectUrl; //Field offset: 0x18
	private IBuffer m_DataBuffer; //Field offset: 0x20
	private IWebRequest m_FlushRequest; //Field offset: 0x28
	[CompilerGenerated]
	private int <ConsecutiveFailedUploadCount>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private bool <FlushInProgress>k__BackingField; //Field offset: 0x34
	private int m_FlushBufferIndex; //Field offset: 0x38

	public private override int ConsecutiveFailedUploadCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	internal bool FlushInProgress
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public Dispatcher(IWebRequestHelper webRequestHelper, string collectUrl) { }

	public override void Flush() { }

	private void FlushBufferToService() { }

	[CompilerGenerated]
	public override int get_ConsecutiveFailedUploadCount() { }

	[CompilerGenerated]
	internal bool get_FlushInProgress() { }

	[CompilerGenerated]
	private void set_ConsecutiveFailedUploadCount(int value) { }

	[CompilerGenerated]
	private void set_FlushInProgress(bool value) { }

	public override void SetBuffer(IBuffer buffer) { }

	private void UploadCompleted(long responseCode) { }

}

