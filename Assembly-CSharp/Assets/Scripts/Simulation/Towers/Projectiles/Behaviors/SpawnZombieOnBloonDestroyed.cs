namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class SpawnZombieOnBloonDestroyed : ProjectileBehavior
{
	private Emission emission; //Field offset: 0x68
	public SpawnZombieOnBloonDestroyedModel spawnZombieModel; //Field offset: 0x70

	private MagusPerfectusGraveyardStateManager GraveyardManager
	{
		private get { } //Length: 212
	}

	private Tower ParagonTower
	{
		private get { } //Length: 198
	}

	private ObjectId ParagonTowerId
	{
		private get { } //Length: 161
	}

	public SpawnZombieOnBloonDestroyed() { }

	public virtual void Collide(Bloon bloon) { }

	private MagusPerfectusGraveyardStateManager get_GraveyardManager() { }

	private Tower get_ParagonTower() { }

	private ObjectId get_ParagonTowerId() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

