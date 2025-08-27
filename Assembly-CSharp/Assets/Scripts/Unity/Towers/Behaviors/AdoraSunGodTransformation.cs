namespace Assets.Scripts.Unity.Towers.Behaviors;

public class AdoraSunGodTransformation : TowerBehavior
{
	public AdoraSunGodTransformation parent; //Field offset: 0x98
	public GameObject newDisplay; //Field offset: 0xA0
	public GameObject expNewDisplay; //Field offset: 0xA8
	public int damageBoost; //Field offset: 0xB0
	public string expDamageBoost; //Field offset: 0xB8
	public int pierceBoost; //Field offset: 0xC0
	public string expPierceBoost; //Field offset: 0xC8
	public int ballOfLightDamageBonus; //Field offset: 0xD0
	public string expBallOfLightDamageBonus; //Field offset: 0xD8
	public int ballOfLightPierceBonus; //Field offset: 0xE0
	public string expBallOfLightPierceBonus; //Field offset: 0xE8
	public int upgradeAnimation; //Field offset: 0xF0
	public string expUpgradeAnimation; //Field offset: 0xF8
	public float weaponDelay; //Field offset: 0x100
	public string expWeaponDelay; //Field offset: 0x108
	public Effect effect; //Field offset: 0x110
	public Effect expEffect; //Field offset: 0x118
	public GameObject portrait; //Field offset: 0x120
	public GameObject expPortrait; //Field offset: 0x128
	public GameObject newDisplayDark; //Field offset: 0x130
	public GameObject expNewDisplayDark; //Field offset: 0x138
	public GameObject projectileDisplayDark; //Field offset: 0x140
	public GameObject expProjectileDisplayDark; //Field offset: 0x148
	public GameObject bolDisplayDark; //Field offset: 0x150
	public GameObject expBolDisplayDark; //Field offset: 0x158
	public GameObject bolProjectileDisplayDark; //Field offset: 0x160
	public GameObject expBolProjectileDisplayDark; //Field offset: 0x168
	public GameObject laolProjectileDisplayDark; //Field offset: 0x170
	public GameObject expLaolProjectileDisplayDark; //Field offset: 0x178
	public Effect effectDark; //Field offset: 0x180
	public Effect expEffectDark; //Field offset: 0x188
	public GameObject portraitDark; //Field offset: 0x190
	public GameObject expPortraitDark; //Field offset: 0x198
	public int upgradeAnimationDark; //Field offset: 0x1A0
	public string expUpgradeAnimationDark; //Field offset: 0x1A8
	public GameObject beamHitDisplayDark; //Field offset: 0x1B0
	public GameObject expBeamHitDisplayDark; //Field offset: 0x1B8
	public AbilityBehavior longArmOfLightBehavior; //Field offset: 0x1C0
	public AbilityBehavior expLongArmOfLightBehavior; //Field offset: 0x1C8
	public Tower ballOfLightTower; //Field offset: 0x1D0
	public Tower expBallOfLightTower; //Field offset: 0x1D8
	public AdoraTransformSound adoraTransformSounds; //Field offset: 0x1E0
	public AdoraTransformSound expAdoraTransformSounds; //Field offset: 0x1E8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 1613
	}

	public AdoraSunGodTransformation() { }

	public virtual TowerBehaviorModel get_Def() { }

}

