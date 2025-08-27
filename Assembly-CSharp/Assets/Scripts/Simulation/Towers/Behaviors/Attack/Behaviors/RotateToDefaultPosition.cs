namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class RotateToDefaultPosition : AttackBehavior
{
	public RotateToDefaultPositionModel rotateToDefaultPositionModel; //Field offset: 0x68

	public RotateToDefaultPosition() { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

