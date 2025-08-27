namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "SlowForBloon", menuName = "BTD6/Behaviors/Projectiles/SlowForBloon")]
public class SlowForBloon : Slow
{
	public string bloonId; //Field offset: 0x80
	public string bloonTag; //Field offset: 0x88
	public bool excluding; //Field offset: 0x90

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 599
	}

	public SlowForBloon() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

