namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class CreateSoundOnAttached : TowerBehavior
{
	public CreateSoundOnAttachedModel createSoundOnAttachedModel; //Field offset: 0x68

	public CreateSoundOnAttached() { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void PlaySound() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

