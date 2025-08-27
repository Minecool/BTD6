namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public abstract class MagusPerfectusAbilityBehavior : AbilityBehavior
{

	protected MagusPerfectusGraveyardStateManager GraveyardManager
	{
		 get { } //Length: 25
	}

	protected Tower ParagonTower
	{
		 get { } //Length: 148
	}

	private ObjectId ParagonTowerId
	{
		private get { } //Length: 115
	}

	protected MagusPerfectusAbilityBehavior() { }

	protected MagusPerfectusGraveyardStateManager get_GraveyardManager() { }

	protected Tower get_ParagonTower() { }

	private ObjectId get_ParagonTowerId() { }

}

