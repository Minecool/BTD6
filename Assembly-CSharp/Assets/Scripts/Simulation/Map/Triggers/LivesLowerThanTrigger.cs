namespace Assets.Scripts.Simulation.Map.Triggers;

public class LivesLowerThanTrigger : MapTrigger
{
	private LivesLowerThanTriggerModel livesLowerThanTriggerModel; //Field offset: 0x80

	public LivesLowerThanTrigger() { }

	public virtual void Init() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void OnLivesGained(int amount) { }

	private void OnLivesLost(int amount) { }

}

