namespace Assets.Scripts.Unity.Map.Triggers;

public class EmitProjectileAction : MapAction
{
	public Projectile projectile; //Field offset: 0x20
	public PrefabReference projectileDisplay; //Field offset: 0x28
	public Emission emission; //Field offset: 0x30
	public GameObject position; //Field offset: 0x38
	public float delay; //Field offset: 0x40
	public bool setDirection; //Field offset: 0x44
	public float emitRotationDegrees; //Field offset: 0x48
	public string targetPriority; //Field offset: 0x50
	public float targetRange; //Field offset: 0x58
	private MapActionModel def; //Field offset: 0x60

	public virtual MapActionModel Def
	{
		 get { } //Length: 688
	}

	public EmitProjectileAction() { }

	public virtual MapActionModel get_Def() { }

}

