namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class MoveWithAirUnit : BloonBehavior
{
	public MoveWithAirUnitModel moveWithAirUnitModel; //Field offset: 0x70
	public AirUnit airUnit; //Field offset: 0x78
	public Vector2 offset; //Field offset: 0x80

	public MoveWithAirUnit() { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	public void Release() { }

	public void SetAirUnit(AirUnit airUnit, Vector2 offset) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

