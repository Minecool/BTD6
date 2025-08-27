namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class MagusPerfectusGraveyard : WeaponBehavior
{
	public MagusPerfectusGraveyardModel graveyardModel; //Field offset: 0x68

	private MagusPerfectusGraveyardStateManager GraveyardManager
	{
		private get { } //Length: 180
	}

	private Tower ParagonTower
	{
		private get { } //Length: 170
	}

	private ObjectId ParagonTowerId
	{
		private get { } //Length: 133
	}

	public MagusPerfectusGraveyard() { }

	public virtual bool FilterEmission() { }

	private MagusPerfectusGraveyardStateManager get_GraveyardManager() { }

	private Tower get_ParagonTower() { }

	private ObjectId get_ParagonTowerId() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void ProjectilesCreated(List<Projectile> projectiles) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

