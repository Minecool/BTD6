namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class MoabShoveZone : TowerBehavior
{
	private const int tickRate = 30; //Field offset: 0x0
	public MoabShoveZoneModel moabShoveZoneModel; //Field offset: 0x68
	private TransformBehavior helicopterTransform; //Field offset: 0x70
	private int lastAffectedBloonAt; //Field offset: 0x78
	private MoabShoveMutator mutator; //Field offset: 0x80

	public MoabShoveZone() { }

	private void AffectBloon(Bloon bloon) { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private bool IsBloonValid(Bloon bloon) { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

