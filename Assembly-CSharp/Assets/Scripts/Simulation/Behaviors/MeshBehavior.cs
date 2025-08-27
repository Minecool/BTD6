namespace Assets.Scripts.Simulation.Behaviors;

public class MeshBehavior : RootBehavior
{
	public Mesh mesh; //Field offset: 0x58
	protected float currentRange; //Field offset: 0x60
	public Vector3 currentPosition; //Field offset: 0x64
	public bool sharedRangeMesh; //Field offset: 0x70

	public MeshBehavior() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

}

