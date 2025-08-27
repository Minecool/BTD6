namespace Assets.Scripts.Models.Profile;

public class SweepstakesDataHelper
{

	public SweepstakesDataHelper() { }

	public void AddAnalyticsStatsToActiveTask(AnalyticsKonFuze toAdd) { }

	public bool AdvanceToNextTask(int unlockedTaskIndex = 0) { }

	public SweepstakesStatsForTask GetStatsForActiveTask() { }

	public ValueTuple<Boolean, SweepstakesEvent, SweepstakesEventSettings> GetSweepstakesEventAndSettings() { }

	public int GetTaskIndexForCurrentEvent() { }

	public int GetTaskIndexForEvent(string eventId) { }

	public static bool HasTicketsPendingClaim(SweepstakesEvent sweepstakesEvent, SweepstakesStatusResponse sweepstakesStatus, SweepstakesStats stats) { }

	public bool IsCurrentTaskExpired(bool canUnlockNextDay = false) { }

	public bool IsTaskActive() { }

	public void Validate() { }

}

