namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class Curve
{
	[SerializeField]
	private Single[] samples; //Field offset: 0x10

	public Curve(Single[] samples) { }

	public float Evaluate(float t) { }

}

