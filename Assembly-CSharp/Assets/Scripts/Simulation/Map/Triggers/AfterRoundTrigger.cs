namespace Assets.Scripts.Simulation.Map.Triggers;

public class AfterRoundTrigger : MapTrigger
{
	private AfterRoundTriggerModel modl; //Field offset: 0x80
	private bool hasTriggeredFromRoundSkip; //Field offset: 0x88

	public AfterRoundTrigger() { }

	private void CallTrigger(int _) { }

	public virtual void CheckIfTriggered() { }

	public virtual void DeInit() { }

	private int GetTriggerCount(int offset = 0) { }

	public virtual void Init() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void OnRoundEnd(int highestCompletedRound) { }

	private void OnRoundSet(bool fromSave) { }

	private bool TriggerCond(int offset = 0) { }

}

