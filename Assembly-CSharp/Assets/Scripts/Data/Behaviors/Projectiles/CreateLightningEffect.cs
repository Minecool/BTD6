namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "CreateLightningEffect", menuName = "BTD6/Behaviors/Projectiles/CreateLightningEffect")]
public class CreateLightningEffect : ProjectileBehavior
{
	public float lifespan; //Field offset: 0x30
	public PrefabReference display1Small; //Field offset: 0x38
	public float display1SmallHeight; //Field offset: 0x40
	public PrefabReference display2Small; //Field offset: 0x48
	public float display2SmallHeight; //Field offset: 0x50
	public PrefabReference display3Small; //Field offset: 0x58
	public float display3SmallHeight; //Field offset: 0x60
	public PrefabReference display1Medium; //Field offset: 0x68
	public float display1MediumHeight; //Field offset: 0x70
	public PrefabReference display2Medium; //Field offset: 0x78
	public float display2MediumHeight; //Field offset: 0x80
	public PrefabReference display3Medium; //Field offset: 0x88
	public float display3MediumHeight; //Field offset: 0x90
	public PrefabReference display1Large; //Field offset: 0x98
	public float display1LargeHeight; //Field offset: 0xA0
	public PrefabReference display2Large; //Field offset: 0xA8
	public float display2LargeHeight; //Field offset: 0xB0
	public PrefabReference display3Large; //Field offset: 0xB8
	public float display3LargeHeight; //Field offset: 0xC0

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 539
	}

	public CreateLightningEffect() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

