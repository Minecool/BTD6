namespace Assets.Scripts.Data.Behaviors.Emissions;

[CreateAssetMenu(fileName = "LineProjectileEmission", menuName = "BTD6/Behaviors/Emissions/LineProjectileEmission")]
public class LineProjectileEmission : Emission
{
	public bool useTargetAsEndPoint; //Field offset: 0x30
	public AssetPath display; //Field offset: 0x38
	public float displayLifetime; //Field offset: 0x40
	public bool ignoreBlockers; //Field offset: 0x44
	public Effect effectAtEnd; //Field offset: 0x48
	public Effect effectAtStart; //Field offset: 0x50
	public float effectAtEndRate; //Field offset: 0x58
	public bool dontUseTowerPosition; //Field offset: 0x5C
	public bool useTowerRotation; //Field offset: 0x5D
	public bool useLengthSpeed; //Field offset: 0x5E
	public float lengthSpeed; //Field offset: 0x60
	public Projectile projectileInitialHit; //Field offset: 0x68
	public Projectile projectileAtEnd; //Field offset: 0x70
	public Emission emissionAtEnd; //Field offset: 0x78
	public bool endProjectileSharesPierce; //Field offset: 0x80
	public float displayLength; //Field offset: 0x84
	public Effect effectAtCollision; //Field offset: 0x88
	public int maxCollisionEffects; //Field offset: 0x90
	public bool emitFromTarget; //Field offset: 0x94
	public float emitFromTargetLength; //Field offset: 0x98

	public virtual EmissionModel Def
	{
		 get { } //Length: 1032
	}

	public LineProjectileEmission() { }

	public virtual EmissionModel get_Def() { }

}

