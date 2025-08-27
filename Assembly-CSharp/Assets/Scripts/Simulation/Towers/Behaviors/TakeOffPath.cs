namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class TakeOffPath : PathSupplier
{
	private Vector2 p2; //Field offset: 0xA0
	private float exponent; //Field offset: 0xA8
	private float length; //Field offset: 0xAC

	public TakeOffPath(float exponent, float speed, float timeToTake) { }

	public virtual float GetPathLength() { }

	public virtual Vector2 GetPathPosition(float t) { }

}

