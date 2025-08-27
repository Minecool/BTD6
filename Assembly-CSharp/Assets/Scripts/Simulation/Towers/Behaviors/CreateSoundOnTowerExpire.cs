namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class CreateSoundOnTowerExpire : TowerBehavior
{
	public CreateSoundOnTowerExpireModel createSoundOnTowerExpireModel; //Field offset: 0x68

	public CreateSoundOnTowerExpire() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnExpire() { }

	private void PlayExpireSound() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

