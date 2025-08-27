namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class CreateLightningEffect : ProjectileBehavior
{
	public CreateLightningEffect parent; //Field offset: 0x88
	public float lifespan; //Field offset: 0x90
	public string expLifespan; //Field offset: 0x98
	public GameObject display1Small; //Field offset: 0xA0
	public GameObject expDisplay1Small; //Field offset: 0xA8
	public GameObject display2Small; //Field offset: 0xB0
	public GameObject expDisplay2Small; //Field offset: 0xB8
	public GameObject display3Small; //Field offset: 0xC0
	public GameObject expDisplay3Small; //Field offset: 0xC8
	public GameObject display1Medium; //Field offset: 0xD0
	public GameObject expDisplay1Medium; //Field offset: 0xD8
	public GameObject display2Medium; //Field offset: 0xE0
	public GameObject expDisplay2Medium; //Field offset: 0xE8
	public GameObject display3Medium; //Field offset: 0xF0
	public GameObject expDisplay3Medium; //Field offset: 0xF8
	public GameObject display1Large; //Field offset: 0x100
	public GameObject expDisplay1Large; //Field offset: 0x108
	public GameObject display2Large; //Field offset: 0x110
	public GameObject expDisplay2Large; //Field offset: 0x118
	public GameObject display3Large; //Field offset: 0x120
	public GameObject expDisplay3Large; //Field offset: 0x128

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 1318
	}

	public CreateLightningEffect() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

