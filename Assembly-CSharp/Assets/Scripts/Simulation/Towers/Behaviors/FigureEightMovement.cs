namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class FigureEightMovement : TowerBehavior
{
	private float currentAngle; //Field offset: 0x68
	public FigureEightMovementModel figureEightMovementModel; //Field offset: 0x70

	public FigureEightMovement() { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

