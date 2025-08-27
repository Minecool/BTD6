namespace Assets.Scripts.Unity.Towers.Behaviors;

public class ParagonTower : TowerBehavior
{
	public ParagonTower parent; //Field offset: 0x98
	public GameObject displayDegree1; //Field offset: 0xA0
	public GameObject expdisplayDegree1; //Field offset: 0xA8
	public GameObject displayDegree2; //Field offset: 0xB0
	public GameObject expdisplayDegree2; //Field offset: 0xB8
	public GameObject displayDegree3; //Field offset: 0xC0
	public GameObject expdisplayDegree3; //Field offset: 0xC8
	public GameObject displayDegree4; //Field offset: 0xD0
	public GameObject expdisplayDegree4; //Field offset: 0xD8
	public GameObject displayDegree5; //Field offset: 0xE0
	public GameObject expdisplayDegree5; //Field offset: 0xE8
	public Effect effectDuring; //Field offset: 0xF0
	public Effect expEffectDuring; //Field offset: 0xF8
	public Effect endEffect; //Field offset: 0x100
	public Effect expEndEffect; //Field offset: 0x108
	public Effect investmentEffect; //Field offset: 0x110
	public Effect expInvestmentEffect; //Field offset: 0x118
	public Effect investmentEffectTier5; //Field offset: 0x120
	public Effect expInvestmentEffectTier5; //Field offset: 0x128
	public float effectMinScale; //Field offset: 0x130
	public string expEffectMinScale; //Field offset: 0x138
	public float effectMaxScale; //Field offset: 0x140
	public string expEffectMaxScale; //Field offset: 0x148
	public float investStartScale; //Field offset: 0x150
	public string expInvestStartScale; //Field offset: 0x158
	public float investEndScale; //Field offset: 0x160
	public string expInvestEndScale; //Field offset: 0x168
	public float inactiveDuration; //Field offset: 0x170
	public string expInactiveDuration; //Field offset: 0x178
	public int endAnimationState; //Field offset: 0x180
	public string expEndAnimationState; //Field offset: 0x188
	public float effectsStartMovingAt; //Field offset: 0x190
	public string expEffectsStartMovingAt; //Field offset: 0x198
	public float effectsDontStartMovingAt; //Field offset: 0x1A0
	public string expEffectsDontStartMovingAt; //Field offset: 0x1A8
	public float investmentEffectHeight; //Field offset: 0x1B0
	public string expInvestmentEffectHeight; //Field offset: 0x1B8
	public float investmentEffectDestYOffset; //Field offset: 0x1C0
	public string expInvestmentEffectDestYOffset; //Field offset: 0x1C8
	public GameObject degreeTextEffect; //Field offset: 0x1D0
	public GameObject expDegreeTextEffect; //Field offset: 0x1D8
	public float degreeTextEffectLifespan; //Field offset: 0x1E0
	public string expDegreeTextEffectLifespan; //Field offset: 0x1E8
	public bool changeAttackDisplay; //Field offset: 0x1F0
	public string expChangeAttackDisplay; //Field offset: 0x1F8
	public bool changeAirUnitDisplay; //Field offset: 0x200
	public string expChangeAirUnitDisplay; //Field offset: 0x208
	public float effectScaleDownTime; //Field offset: 0x210
	public string expEffectScaleDownTime; //Field offset: 0x218
	public float investmentEffectExponent; //Field offset: 0x220
	public string expInvestmentEffectExponent; //Field offset: 0x228
	public bool repositionStackedTowers; //Field offset: 0x230
	public string expRepositionStackedTowers; //Field offset: 0x238
	public AudioClip sound; //Field offset: 0x240
	public AudioClip expSound; //Field offset: 0x248
	public AudioClip altSound; //Field offset: 0x250
	public AudioClip expAltSound; //Field offset: 0x258

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 2606
	}

	public ParagonTower() { }

	public virtual TowerBehaviorModel get_Def() { }

}

