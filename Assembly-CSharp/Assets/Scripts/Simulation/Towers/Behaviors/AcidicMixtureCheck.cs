namespace Assets.Scripts.Simulation.Towers.Behaviors;

internal class AcidicMixtureCheck : TowerBehavior
{
	public AcidicMixtureCheckModel acidicMixtureCheckModel; //Field offset: 0x68
	public int count; //Field offset: 0x70
	public bool removed; //Field offset: 0x74

	public AcidicMixtureCheck() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	public void UseAcidicMixture(int ammoCount = 1) { }

}

