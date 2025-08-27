namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class NecroEmissionFilter : WeaponBehavior
{
	public NecroEmissionFilterModel necroEmissionFilterModel; //Field offset: 0x68
	private SimNecromancerGraveyardManager graveyardManager; //Field offset: 0x70
	private int minRbeNeeded; //Field offset: 0x78

	public NecroEmissionFilter() { }

	public virtual bool FilterEmission() { }

	private void GetMinRbeNeeed() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

