namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(CreateProp), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreatePropModel : ProjectileBehaviorModel
{
	public PropModel propModel; //Field offset: 0x38
	public bool isCollidable; //Field offset: 0x40
	public int count; //Field offset: 0x44
	public Int32[] skipProjectileIndexs; //Field offset: 0x48
	public PropModel optionalSkippedPropReplacement; //Field offset: 0x50
	public int spacing; //Field offset: 0x58
	public bool isArcEmission; //Field offset: 0x5C
	public int arcEmissionAngle; //Field offset: 0x60
	public int arcEmissionOffset; //Field offset: 0x64
	public bool overrideRotation; //Field offset: 0x68
	public float overriddenRotation; //Field offset: 0x6C
	public bool overrideDirection; //Field offset: 0x70
	public float overriddenDirection; //Field offset: 0x74
	public float zHeight; //Field offset: 0x78
	public bool randomizeEachPropScale; //Field offset: 0x7C
	public float scaleMinX; //Field offset: 0x80
	public float scaleMaxX; //Field offset: 0x84
	public float scaleMinY; //Field offset: 0x88
	public float scaleMaxY; //Field offset: 0x8C
	public bool randomizeEachPropOffset; //Field offset: 0x90
	public int offsetMinX; //Field offset: 0x94
	public int offsetMaxX; //Field offset: 0x98
	public int offsetMinY; //Field offset: 0x9C
	public int offsetMaxY; //Field offset: 0xA0
	public bool offsetAfterRotation; //Field offset: 0xA4

	public CreatePropModel(string name, PropModel propModel, bool isCollidable, float zHeight, int count, Int32[] skipProjectileIndexs, PropModel optionalSkippedPropReplacement, int spacing, bool overrideRotation, float overriddenRotation, bool overrideDirection, float overriddenDirection, bool isArcEmission, int arcEmissionAngle, int arcEmissionOffset, bool randomizeEachPropScale, float scaleMinX, float scaleMaxX, float scaleMinY, float scaleMaxY, bool offsetAfterRotation, bool randomizeEachPropOffset, int offsetMinX, int offsetMaxX, int offsetMinY, int offsetMaxY) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

