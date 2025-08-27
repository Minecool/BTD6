namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class Lives : ProjectileBehavior
{
	public LivesModel livesModel; //Field offset: 0x68
	private bool cashedIn; //Field offset: 0x70

	private float Amount
	{
		private get { } //Length: 115
	}

	public Lives() { }

	public virtual void Exhausted() { }

	private float get_Amount() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual float Pickup() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

