namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class CritRollWithDistance : CritRoll
{
	private CritRollWithDistanceModel critRollWithDistanceModel; //Field offset: 0x70

	public CritRollWithDistance() { }

	public virtual float CritChanceOffset() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

