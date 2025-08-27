namespace Assets.Scripts.Simulation.Towers.Pets;

public class PetTerrainHandler : PetBehavior
{
	private PetTerrainHandlerModel petTerrainHandlerModel; //Field offset: 0x60
	private float currZ; //Field offset: 0x68

	public PetTerrainHandler() { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

}

