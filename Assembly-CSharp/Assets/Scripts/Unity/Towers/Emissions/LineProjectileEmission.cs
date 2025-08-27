namespace Assets.Scripts.Unity.Towers.Emissions;

public class LineProjectileEmission : Emission
{
	public LineProjectileEmission parent; //Field offset: 0x88
	public bool useTargetAsEndPoint; //Field offset: 0x90
	public string expUseTargetAsEndPoint; //Field offset: 0x98
	public GameObject display; //Field offset: 0xA0
	public GameObject expDisplay; //Field offset: 0xA8
	public float displayLifetime; //Field offset: 0xB0
	public string expDisplayLifetime; //Field offset: 0xB8
	public bool ignoreBlockers; //Field offset: 0xC0
	public string expIgnoreBlockers; //Field offset: 0xC8
	public Effect effectAtEnd; //Field offset: 0xD0
	public Effect expEffectAtEnd; //Field offset: 0xD8
	public Effect effectAtStart; //Field offset: 0xE0
	public Effect expEffectAtStart; //Field offset: 0xE8
	public float effectAtEndRate; //Field offset: 0xF0
	public string expEffectAtEndRate; //Field offset: 0xF8
	public bool dontUseTowerPosition; //Field offset: 0x100
	public string expDontUseTowerPosition; //Field offset: 0x108
	public bool useTowerRotation; //Field offset: 0x110
	public string expUseTowerRotation; //Field offset: 0x118
	public bool useLengthSpeed; //Field offset: 0x120
	public string expUseLengthSpeed; //Field offset: 0x128
	public float lengthSpeed; //Field offset: 0x130
	public string expLengthSpeed; //Field offset: 0x138
	public Projectile projectileInitialHit; //Field offset: 0x140
	public Projectile projectileAtEnd; //Field offset: 0x148
	public Emission emissionAtEnd; //Field offset: 0x150
	public Emission expEmissionAtEnd; //Field offset: 0x158
	public bool endProjectileSharesPierce; //Field offset: 0x160
	public string expEndProjectileSharesPierce; //Field offset: 0x168
	public Effect effectAtCollision; //Field offset: 0x170
	public Effect expEffectAtCollision; //Field offset: 0x178
	public int maxCollisionEffects; //Field offset: 0x180
	public string expMaxCollisionEffects; //Field offset: 0x188
	public bool emitFromTarget; //Field offset: 0x190
	public string expEmitFromTarget; //Field offset: 0x198
	public float emitFromTargetLength; //Field offset: 0x1A0
	public string expEmitFromTargetLength; //Field offset: 0x1A8

	public virtual EmissionModel Def
	{
		 get { } //Length: 1238
	}

	public LineProjectileEmission() { }

	public virtual EmissionModel get_Def() { }

}

