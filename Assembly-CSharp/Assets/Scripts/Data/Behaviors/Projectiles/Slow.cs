namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "Slow", menuName = "BTD6/Behaviors/Projectiles/Slow")]
public class Slow : ProjectileBehavior
{
	public float multiplier; //Field offset: 0x30
	public float lifespan; //Field offset: 0x34
	public int layers; //Field offset: 0x38
	public string mutationId; //Field offset: 0x40
	public string overlayType; //Field offset: 0x48
	public bool isUnique; //Field offset: 0x50
	public bool dontRefreshDuration; //Field offset: 0x51
	public Effect createEffectIfSuccessfullyAffected; //Field offset: 0x58
	public bool cascadeMutators; //Field offset: 0x60
	public bool removeMutatorIfNotMatching; //Field offset: 0x61
	public int glueLevelOverride; //Field offset: 0x64
	public bool matchLayersWithDamage; //Field offset: 0x68
	public FilterGlueLevel filterGlueLevel; //Field offset: 0x70
	public float chance; //Field offset: 0x78

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 571
	}

	public Slow() { }

	public bool CountGlueAchievement() { }

	public virtual ProjectileBehaviorModel get_Def() { }

	public int GetGlueLevel() { }

}

