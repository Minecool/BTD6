namespace Assets.Scripts.Simulation.Bloons.Behaviors.Actions;

public class DashForwardsAction : BloonBehaviorAction
{
	public DashForwardsActionModel dashForwardsActionModel; //Field offset: 0x78
	private bool isDashing; //Field offset: 0x80
	private float endPos; //Field offset: 0x84

	public DashForwardsAction() { }

	private void AddSpeedMutator() { }

	private void DashEndActions() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void PreCollision(Projectile proj) { }

	private void Process(int amount) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

