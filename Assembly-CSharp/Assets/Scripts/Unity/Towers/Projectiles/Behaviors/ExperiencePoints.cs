namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class ExperiencePoints : ProjectileBehavior
{
	public ExperiencePoints parent; //Field offset: 0x88
	public float amount; //Field offset: 0x90
	public string expAmount; //Field offset: 0x98

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 109
	}

	public ExperiencePoints() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

