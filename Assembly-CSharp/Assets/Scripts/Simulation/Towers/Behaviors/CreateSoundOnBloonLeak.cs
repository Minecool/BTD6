namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class CreateSoundOnBloonLeak : TowerBehavior
{
	public CreateSoundOnBloonLeakModel createSoundOnBloonLeakModel; //Field offset: 0x68

	public CreateSoundOnBloonLeak() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnLivesLost(bool fromLeak) { }

	private void PlayLeakSound() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

