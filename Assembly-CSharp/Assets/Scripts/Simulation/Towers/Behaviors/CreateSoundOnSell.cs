namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class CreateSoundOnSell : TowerBehavior
{
	public CreateSoundOnSellModel createSoundOnSellModel; //Field offset: 0x68

	public CreateSoundOnSell() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnSold(float amount) { }

	private void PlaySellSound() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

