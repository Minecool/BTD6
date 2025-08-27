namespace Assets.Scripts.Simulation.Towers.Behaviors;

internal class AmmoBelt : TowerBehavior
{
	public AmmoBeltModel ammoBeltModel; //Field offset: 0x68
	private int count; //Field offset: 0x70
	private float lastRegen; //Field offset: 0x74

	public AmmoBelt() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void Process(int elapsed) { }

	public bool RequestAmmo(int ammoCount = 1) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	public void UseAmmo(int ammoCount = 1) { }

}

