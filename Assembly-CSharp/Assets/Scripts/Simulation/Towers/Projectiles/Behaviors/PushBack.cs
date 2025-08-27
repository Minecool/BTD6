namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class PushBack : ProjectileBehavior
{

	private PushBackModel pushBackModel
	{
		private get { } //Length: 126
	}

	public PushBack() { }

	public virtual void Collide(Bloon bloon) { }

	private PushBackModel get_pushBackModel() { }

	private static float MultiplierForBaseId(PushBackModel model, string baseId) { }

}

