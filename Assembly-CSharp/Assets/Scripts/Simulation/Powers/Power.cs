namespace Assets.Scripts.Simulation.Powers;

public class Power
{
	public Simulation sim; //Field offset: 0x10

	public Power() { }

	public override void Activate(Vector2 location, PowerBehaviorModel model, int inputId) { }

	public override bool CheckLocation(Vector2 location, PowerBehaviorModel model) { }

}

