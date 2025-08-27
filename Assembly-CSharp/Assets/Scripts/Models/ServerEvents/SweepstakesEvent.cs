namespace Assets.Scripts.Models.ServerEvents;

public class SweepstakesEvent : ServerEvent<SweepstakesEventMetadata>
{

	public SweepstakesEvent() { }

	public SweepstakesEventSettings GetEventSettings() { }

	public SweepstakesTaskSettings GetTaskSettings(int taskIndex) { }

}

