namespace Assets.Scripts.Models.Profile;

public class SweepstakesDataHelper
{

	public SweepstakesDataHelper() { }

	public void AddAnalyticsStatsToActiveTask(AnalyticsKonFuze toAdd) { }

	public bool AdvanceToNextTask(int unlockedTaskIndex = 0) { }

	public bool CheckPendingTickets(SweepstakesStatusResponse sweepstakesStatus) { }

	public SweepstakesStatsForTask GetStatsForActiveTask() { }

	public ValueTuple<Boolean, SweepstakesEvent, SweepstakesEventSettings> GetSweepstakesEventAndSettings() { }

	public int GetTaskIndexForCurrentEvent() { }

	public int GetTaskIndexForEvent(string eventId) { }

	public bool IsCurrentTaskExpired(bool canUnlockNextDay = false) { }

	public bool IsTaskActive() { }

	public void Validate() { }

}

