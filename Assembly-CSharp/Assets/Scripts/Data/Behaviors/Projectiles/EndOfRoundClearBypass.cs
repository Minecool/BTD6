namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "EndOfRoundClearBypass", menuName = "BTD6/Behaviors/Projectiles/EndOfRoundClearBypass")]
public class EndOfRoundClearBypass : ProjectileBehavior
{
	public string gameModes; //Field offset: 0x30

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 105
	}

	public EndOfRoundClearBypass() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

