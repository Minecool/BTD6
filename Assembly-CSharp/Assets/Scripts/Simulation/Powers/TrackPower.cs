namespace Assets.Scripts.Simulation.Powers;

public class TrackPower : Power
{

	public TrackPower() { }

	public virtual void Activate(Vector2 location, PowerBehaviorModel model, int inputId) { }

	public virtual bool CheckLocation(Vector2 location, PowerBehaviorModel model) { }

	public void CreateProjectile(Vector2 location, ProjectileModel projModel, int inputId) { }

}

