namespace Assets.Scripts.Simulation.Map.Actions;

public class MapEventActiveAction : MapAction
{
	public MapEventActiveActionModel mapEventActiveActionModel; //Field offset: 0x60

	public MapEventActiveAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

}

