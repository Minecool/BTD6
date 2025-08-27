namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class CreateProjectileOnExhaustFraction : ProjectileBehavior
{
	private CreateProjectileOnExhaustFractionModel cpModel; //Field offset: 0x68
	private Emission emission; //Field offset: 0x70
	private bool isDone; //Field offset: 0x78

	public CreateProjectileOnExhaustFraction() { }

	private void CheckFraction(float pierceFraction, float durationFraction) { }

	public virtual void Exhausted() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

