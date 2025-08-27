namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class CreateRopeEffect : ProjectileBehavior
{
	public CreateRopeEffect parent; //Field offset: 0x88
	public GameObject display; //Field offset: 0x90
	public GameObject expDisplay; //Field offset: 0x98
	public GameObject endDisplay; //Field offset: 0xA0
	public GameObject expEndDisplay; //Field offset: 0xA8
	public float spriteRadius; //Field offset: 0xB0
	public string expSpriteRadius; //Field offset: 0xB8
	public float spriteSpacing; //Field offset: 0xC0
	public string expSpriteSpacing; //Field offset: 0xC8
	public float spriteOffset; //Field offset: 0xD0
	public string expSpriteOffset; //Field offset: 0xD8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 266
	}

	public CreateRopeEffect() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

