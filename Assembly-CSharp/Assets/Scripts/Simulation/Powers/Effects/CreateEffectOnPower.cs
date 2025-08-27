namespace Assets.Scripts.Simulation.Powers.Effects;

public class CreateEffectOnPower : Power
{

	public CreateEffectOnPower() { }

	public virtual void Activate(Vector2 location, PowerBehaviorModel model, int inputId) { }

	public virtual bool CheckLocation(Vector2 location, PowerBehaviorModel model) { }

}

