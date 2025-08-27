namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "AdoraSunGodTransformation", menuName = "BTD6/Behaviors/Towers/AdoraSunGodTransformation")]
public class AdoraSunGodTransformation : TowerBehavior
{
	public AssetPath newDisplay; //Field offset: 0x30
	public int damageBoost; //Field offset: 0x38
	public int pierceBoost; //Field offset: 0x3C
	public int ballOfLightDamageBonus; //Field offset: 0x40
	public int ballOfLightPierceBonus; //Field offset: 0x44
	public int upgradeAnimation; //Field offset: 0x48
	public float weaponDelay; //Field offset: 0x4C
	public Effect effect; //Field offset: 0x50
	public SpriteReference portrait; //Field offset: 0x58
	public AssetPath newDisplayDark; //Field offset: 0x60
	public AssetPath projectileDisplayDark; //Field offset: 0x68
	public AssetPath bolDisplayDark; //Field offset: 0x70
	public AssetPath bolProjectileDisplayDark; //Field offset: 0x78
	public AssetPath laolProjectileDisplayDark; //Field offset: 0x80
	public Effect effectDark; //Field offset: 0x88
	public SpriteReference portraitDark; //Field offset: 0x90
	public int upgradeAnimationDark; //Field offset: 0x98
	public AssetPath beamHitDisplayDark; //Field offset: 0xA0
	public AbilityBehavior longArmOfLightBehavior; //Field offset: 0xA8
	public Tower ballOfLightTower; //Field offset: 0xB0
	public AdoraTransformSound adoraTransformSounds; //Field offset: 0xB8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 1281
	}

	public AdoraSunGodTransformation() { }

	public virtual TowerBehaviorModel get_Def() { }

}

