namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class FrozenBurial : AbilityBehavior
{
	public FrozenBurialModel frozenBurialModel; //Field offset: 0x68
	private Emission emission; //Field offset: 0x70
	private readonly List<Vector3> newPositions; //Field offset: 0x78
	private readonly List<Vector3> positions; //Field offset: 0x80
	private readonly List<PathSegment> invulnerablePathSegments; //Field offset: 0x88
	private int startedAt; //Field offset: 0x90

	public FrozenBurial() { }

	public virtual void Activate() { }

	private void GeneratePositions() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

