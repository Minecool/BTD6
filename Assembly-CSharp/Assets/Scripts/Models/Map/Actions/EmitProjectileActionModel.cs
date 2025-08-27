namespace Assets.Scripts.Models.Map.Actions;

[Implementation(typeof(EmitProjectileAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class EmitProjectileActionModel : MapActionModel
{
	public ProjectileModel projectileModel; //Field offset: 0x38
	public EmissionModel emissionModel; //Field offset: 0x40
	public float positionX; //Field offset: 0x48
	public float positionY; //Field offset: 0x4C
	public float positionZ; //Field offset: 0x50
	[SerializeField]
	private float delay; //Field offset: 0x54
	public int delayFrames; //Field offset: 0x58
	public bool setDirection; //Field offset: 0x5C
	public float emitRotationDegrees; //Field offset: 0x60
	public string targetPriority; //Field offset: 0x68
	public float targetRange; //Field offset: 0x70

	public EmitProjectileActionModel(string name, ProjectileModel projectileModel, EmissionModel emissionModel, float positionX, float positionY, float positionZ, float delay, bool setDirection, float emitRotationDegrees, string targetPriority, float targetRange) { }

}

