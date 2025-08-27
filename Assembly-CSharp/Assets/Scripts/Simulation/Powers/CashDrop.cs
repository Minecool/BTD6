namespace Assets.Scripts.Simulation.Powers;

public class CashDrop : Power
{

	public CashDrop() { }

	public virtual void Activate(Vector2 location, PowerBehaviorModel model, int inputId) { }

	public virtual bool CheckLocation(Vector2 location, PowerBehaviorModel model) { }

}

