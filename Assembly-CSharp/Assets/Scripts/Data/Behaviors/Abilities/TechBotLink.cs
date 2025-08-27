namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "TechBotLink", menuName = "BTD6/Behaviors/Abilities/TechBotLink")]
public class TechBotLink : AbilityBehavior
{
	public PrefabReference selectionObject; //Field offset: 0x30
	public PrefabReference isSelectableObject; //Field offset: 0x38
	public Sound activateSound; //Field offset: 0x40
	public Sound confirmSound; //Field offset: 0x48
	public Effect activatedTowerAbilityEffect; //Field offset: 0x50
	public PrefabReference lineDisplay; //Field offset: 0x58
	public float lineDotOffset; //Field offset: 0x60
	public float lineDotSpacing; //Field offset: 0x64
	public int activateAnimationState; //Field offset: 0x68
	public int linkAnimationState; //Field offset: 0x6C
	public int idleAnimationState; //Field offset: 0x70
	public Effect travelEffect; //Field offset: 0x78
	public float travelEffectSpeed; //Field offset: 0x80
	public Display rotatingDisplay; //Field offset: 0x88

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 596
	}

	public virtual Display Display
	{
		 get { } //Length: 8
	}

	public TechBotLink() { }

	public virtual AbilityBehaviorModel get_Def() { }

	public virtual Display get_Display() { }

}

