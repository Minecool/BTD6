namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class SetSpriteFromPierce : ProjectileBehavior
{
	public SetSpriteFromPierce parent; //Field offset: 0x88
	public SpriteGroup spriteGroup; //Field offset: 0x90
	public SpriteGroup expSpriteGroup; //Field offset: 0x98
	public string loopMode; //Field offset: 0xA0
	public string expLoopMode; //Field offset: 0xA8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 154
	}

	public SetSpriteFromPierce() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

