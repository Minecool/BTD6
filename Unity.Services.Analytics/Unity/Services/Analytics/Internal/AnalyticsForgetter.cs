namespace Unity.Services.Analytics.Internal;

internal class AnalyticsForgetter : IAnalyticsForgetter
{
	private enum DataDeletionStatus
	{
		DataAllowed = 0,
		DeletionInProgress = 1,
		SuccessfullyDeleted = 2,
	}

	private readonly string m_CollectUrl; //Field offset: 0x10
	private readonly IPersistence m_Persistence; //Field offset: 0x18
	private readonly IWebRequestHelper m_WebRequestHelper; //Field offset: 0x20
	private Byte[] m_Event; //Field offset: 0x28
	private Action m_Callback; //Field offset: 0x30
	private DataDeletionStatus m_DeletionStatus; //Field offset: 0x38
	private IWebRequest m_Request; //Field offset: 0x40

	public override bool DeletionInProgress
	{
		 get { } //Length: 8
	}

	internal AnalyticsForgetter(string collectUrl, IPersistence persistence, IWebRequestHelper webRequestHelper) { }

	public override void AttemptToForget(string userId, string installationId, string playerId, string timestamp, string callingMethod, Action successfulUploadCallback) { }

	public override bool get_DeletionInProgress() { }

	private void SetForgettingStatus(DataDeletionStatus state) { }

	private void UploadComplete(long code) { }

}

