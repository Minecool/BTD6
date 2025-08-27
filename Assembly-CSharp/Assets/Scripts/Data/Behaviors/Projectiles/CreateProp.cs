namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "CreateProp", menuName = "BTD6/Behaviors/Projectiles/CreateProp")]
public class CreateProp : ProjectileBehavior
{
	public Prop prop; //Field offset: 0x30
	public bool isCollidable; //Field offset: 0x38
	public int count; //Field offset: 0x3C
	public Int32[] skipProjectile; //Field offset: 0x40
	public Prop optionalSkippedPropReplacement; //Field offset: 0x48
	public int spacing; //Field offset: 0x50
	public bool overrideRotation; //Field offset: 0x54
	public int overridenRotation; //Field offset: 0x58
	public bool overrideDirection; //Field offset: 0x5C
	public int overiddenDirection; //Field offset: 0x60
	public float zHeight; //Field offset: 0x64
	public bool isArcEmission; //Field offset: 0x68
	public int arcEmissionAngle; //Field offset: 0x6C
	public int arcEmissionOffset; //Field offset: 0x70
	public bool randomizeEachPropScale; //Field offset: 0x74
	public float scaleMinX; //Field offset: 0x78
	public float scaleMaxX; //Field offset: 0x7C
	public float scaleMinY; //Field offset: 0x80
	public float scaleMaxY; //Field offset: 0x84
	public bool offsetAfterRotation; //Field offset: 0x88
	public bool randomizeEachPropOffset; //Field offset: 0x89
	public int xOffsetMin; //Field offset: 0x8C
	public int xOffsetMax; //Field offset: 0x90
	public int yOffsetMin; //Field offset: 0x94
	public int yOffsetMax; //Field offset: 0x98

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 915
	}

	public CreateProp() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

