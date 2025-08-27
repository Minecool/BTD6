namespace Assets.Scripts.Simulation.Powers.Effects;

public class CreateSoundOnPower : Power
{
	public CreateSoundOnPowerModel createSoundOnPowerModel; //Field offset: 0x18

	public CreateSoundOnPower() { }

	public virtual void Activate(Vector2 location, PowerBehaviorModel model, int inputId) { }

	public virtual bool CheckLocation(Vector2 location, PowerBehaviorModel model) { }

	private void PlaySound() { }

}

