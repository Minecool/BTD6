namespace Assets.Scripts.Unity.Analytics;

public class AssetBundleAnalytics
{

	public AssetBundleAnalytics() { }

	public void CacheCleared(List<String> clearedBundles) { }

	public void DeviceId() { }

	public void DownloadFinished(AsyncOperationHandle downloadOperation) { }

	public void DownloadRestarted(Exception exception) { }

	public void DownloadStarted(long bytesToDownload) { }

	private AnalyticsData GetBaseEvent(string eventName) { }

	private static string GetProperExceptionMessage(Exception ex) { }

	public void InitFailed(Exception exception) { }

	private void Report(AnalyticsData data) { }

}

