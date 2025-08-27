namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class AttackFilter : AttackBehavior
{
	public AttackFilterModel attackFilterModel; //Field offset: 0x68
	public List<RootBehavior> filters; //Field offset: 0x70

	public AttackFilter() { }

	public virtual bool CantTargetCamo() { }

	public virtual bool CantTargetMoab() { }

	public virtual bool FilterTarget(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool OnlyTargetsMoab() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

