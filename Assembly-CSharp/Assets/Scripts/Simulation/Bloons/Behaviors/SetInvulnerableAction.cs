namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class SetInvulnerableAction : BloonBehaviorAction
{
	private bool isInvulnerable; //Field offset: 0x78
	public SetInvulnerableActionModel setInvulnerableActionModel; //Field offset: 0x80

	public SetInvulnerableAction() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	private void PlaySound() { }

	private void SetInvulnerable(bool set) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

