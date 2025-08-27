namespace Assets.Scripts.Simulation.Map.Actions;

public class CycleAreasAction : MapAction
{
	private CycleAreasActionModel cycleAreasActionModel; //Field offset: 0x60
	private int lastRotationIndex; //Field offset: 0x68

	public CycleAreasAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

}

