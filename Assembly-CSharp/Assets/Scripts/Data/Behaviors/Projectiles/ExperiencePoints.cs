namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "ExperiencePoints", menuName = "BTD6/Behaviors/Projectiles/ExperiencePoints")]
public class ExperiencePoints : ProjectileBehavior
{
	public float amount; //Field offset: 0x30

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 106
	}

	public ExperiencePoints() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

