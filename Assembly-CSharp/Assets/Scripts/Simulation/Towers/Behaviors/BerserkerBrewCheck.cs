namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class BerserkerBrewCheck : TowerBehavior
{
	public BerserkerBrewCheckModel berserkerBrewCheckModel; //Field offset: 0x68
	public int count; //Field offset: 0x70
	public bool removed; //Field offset: 0x74

	public BerserkerBrewCheck() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	public void UseBerserkerBrew(int ammoCount = 1) { }

}

