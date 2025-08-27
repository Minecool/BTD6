namespace Assets.Scripts.Simulation.Towers.Mutators.Conditions.Behaviors;

public class CheckTempleUnderLevel : Conditional
{
	public CheckTempleUnderLevelModel checkTempleModel; //Field offset: 0x58

	public CheckTempleUnderLevel() { }

	public virtual bool Evaluate() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

