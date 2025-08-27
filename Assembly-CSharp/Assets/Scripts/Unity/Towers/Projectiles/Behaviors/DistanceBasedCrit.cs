namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class DistanceBasedCrit : ProjectileBehavior
{
	public DistanceBasedCrit parent; //Field offset: 0x88
	public float critDamageBonusMult; //Field offset: 0x90
	public string expCritDamageBonusMult; //Field offset: 0x98
	public float baseCritChance; //Field offset: 0xA0
	public string expBaseCritChance; //Field offset: 0xA8
	public float bonusCritChancePerDistance; //Field offset: 0xB0
	public string expBonusCritChancePerDistance; //Field offset: 0xB8
	public float happyCurveInfluence; //Field offset: 0xC0
	public string expHappyCurveInfluence; //Field offset: 0xC8
	public GameObject textDisplay; //Field offset: 0xD0
	public GameObject expTextDisplay; //Field offset: 0xD8
	public float textLifespan; //Field offset: 0xE0
	public string expTextLifespan; //Field offset: 0xE8
	public string text; //Field offset: 0xF0
	public string expText; //Field offset: 0xF8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 609
	}

	public DistanceBasedCrit() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

