namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class CreateSoundOnTowerPlace : TowerBehavior
{
	public CreateSoundOnTowerPlaceModel createSoundOnTowerPlaceModel; //Field offset: 0x68

	public CreateSoundOnTowerPlace() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnPlace(bool playPlacementEffects) { }

	private void PlayHeroPlaceSound() { }

	private void PlayHeroReactVoice() { }

	private void PlayPlaceSound(bool placeOnLand = true) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

