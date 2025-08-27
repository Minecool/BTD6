namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "SetSpriteFromPierce", menuName = "BTD6/Behaviors/Projectiles/SetSpriteFromPierce")]
public class SetSpriteFromPierce : ProjectileBehavior
{
	public SpriteGroup spriteGroup; //Field offset: 0x30
	public string loopMode; //Field offset: 0x38

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 142
	}

	public SetSpriteFromPierce() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

