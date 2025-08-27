namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "BloonSlap", menuName = "BTD6/Behaviors/Projectiles/BloonSlap")]
public class BloonSlap : ProjectileBehavior
{
	public int valueForNormalBloons; //Field offset: 0x30
	public int valueForCeramicBloons; //Field offset: 0x34
	public int heavyMultiplier; //Field offset: 0x38
	public int lightMultiplier; //Field offset: 0x3C
	public float lifespan; //Field offset: 0x40
	public string mutationId; //Field offset: 0x48

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 192
	}

	public BloonSlap() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

