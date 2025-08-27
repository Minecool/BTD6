namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class CreateSoundOnMonkeyMoneyActivated : TowerBehavior
{
	public CreateSoundOnMonkeyMoneyActivatedModel createSoundOnMonkeyMoneyActivatedModel; //Field offset: 0x68

	public CreateSoundOnMonkeyMoneyActivated() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformCustomUIAction() { }

	private void PlayMMActivatedSound() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

