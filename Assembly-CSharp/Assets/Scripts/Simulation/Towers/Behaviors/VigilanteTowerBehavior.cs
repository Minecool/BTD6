namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class VigilanteTowerBehavior : TowerBehavior
{
	public VigilanteTowerBehaviorModel vigilanteTowerBehaviorModel; //Field offset: 0x68
	private int lastActivatedAt; //Field offset: 0x70
	private BloonModel oneHealthHighestBloonModel; //Field offset: 0x78
	private HashSet<Bloon> gainedCashFromBloonsThisFrame; //Field offset: 0x80

	public VigilanteTowerBehavior() { }

	public virtual float GetModifiedLeakLivesLost(Bloon leakedBloon, float livesToLose) { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private bool IsActive() { }

	private bool IsInCooldown() { }

	public virtual void LateSetSaveMetaData(Dictionary<String, String> metaData) { }

	private void OnBloonLeaked(Bloon bloon, float livesBefore, float livesAfter, float manaShieldBefore, float manaShieldAfter) { }

	protected virtual void OnDestroy() { }

	private void OnLivesLost(int amount) { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

