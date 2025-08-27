namespace Assets.Scripts.Unity.Analytics;

public class TwitchAnalytics
{

	public TwitchAnalytics() { }

	public void Exception(Exception ex, string exceptionType) { }

	private AnalyticsData GetBaseEvent(string eventName) { }

	public void LoggedIn(string twitchUsername) { }

	public void LoggedOut() { }

	public void PollCancelled() { }

	public void PollFailed() { }

	public void PollFinished(IEnumerable<String> winningTowerIds, long totalVotes) { }

	public void PollStarted(IEnumerable<String> towerIds, int maxWinners) { }

	private void Report(AnalyticsData data) { }

}

