namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class Slow : ProjectileBehavior
{
	public Slow parent; //Field offset: 0x88
	public float multiplier; //Field offset: 0x90
	public string expMultiplier; //Field offset: 0x98
	public float lifespan; //Field offset: 0xA0
	public string expLifespan; //Field offset: 0xA8
	public int layers; //Field offset: 0xB0
	public string expLayers; //Field offset: 0xB8
	public string mutationId; //Field offset: 0xC0
	public string expMutationId; //Field offset: 0xC8
	public string overlayType; //Field offset: 0xD0
	public string expOverlayType; //Field offset: 0xD8
	public bool isUnique; //Field offset: 0xE0
	public string expIsUnique; //Field offset: 0xE8
	public bool dontRefreshDuration; //Field offset: 0xF0
	public string expDontRefreshDuration; //Field offset: 0xF8
	public Effect createEffectIfSuccessfullyAffected; //Field offset: 0x100
	public Effect expCreateEffectIfSuccessfullyAffected; //Field offset: 0x108
	public bool cascadeMutators; //Field offset: 0x110
	public string expCascadeMutators; //Field offset: 0x118
	public bool removeMutatorIfNotMatching; //Field offset: 0x120
	public string expRemoveMutatorIfNotMatching; //Field offset: 0x128
	public int glueLevelOverride; //Field offset: 0x130
	public string expGlueLevelOverride; //Field offset: 0x138
	public bool matchLayersWithDamage; //Field offset: 0x140
	public string expMatchLayersWithDamage; //Field offset: 0x148
	public float chance; //Field offset: 0x150
	public string expChance; //Field offset: 0x158

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 601
	}

	public Slow() { }

	public bool CountGlueAchievement() { }

	public virtual ProjectileBehaviorModel get_Def() { }

	public int GetGlueLevel() { }

}

