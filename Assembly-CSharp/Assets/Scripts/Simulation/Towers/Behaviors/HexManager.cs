namespace Assets.Scripts.Simulation.Towers.Behaviors;

internal class HexManager : TowerBehavior
{
	public HexManagerModel hexManagerModel; //Field offset: 0x68
	public bool findNewTarget; //Field offset: 0x70
	public int ticksRemaining; //Field offset: 0x74
	public Vector3 position; //Field offset: 0x78
	public Attack attack; //Field offset: 0x88

	public HexManager() { }

	public void FindNewTarget() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void JumpHexToNextTarget(int ticksRemaining, Vector3 position) { }

	public void Process(int ticks) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

