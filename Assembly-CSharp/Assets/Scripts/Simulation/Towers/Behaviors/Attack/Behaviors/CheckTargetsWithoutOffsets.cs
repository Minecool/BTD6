namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class CheckTargetsWithoutOffsets : AttackBehavior
{
	public CheckTargetsWithoutOffsetsModel checkTargetsWithoutOffsetsModel; //Field offset: 0x68

	public CheckTargetsWithoutOffsets() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

