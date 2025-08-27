namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class CreateSoundOnUpgrade : TowerBehavior
{
	public CreateSoundOnUpgradeModel createSoundOnUpgradeModel; //Field offset: 0x68

	public CreateSoundOnUpgrade() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnUpgrade(bool playUpgradeEffect) { }

	private void PlayHeroUpgradeSound() { }

	private void PlayUpgradeSound() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

