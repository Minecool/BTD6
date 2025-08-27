namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class TechBotLink : AbilityBehavior
{
	public TechBotLink parent; //Field offset: 0x88
	public GameObject selectionObject; //Field offset: 0x90
	public GameObject expSelectionObject; //Field offset: 0x98
	public GameObject isSelectableObject; //Field offset: 0xA0
	public GameObject expIsSelectableObject; //Field offset: 0xA8
	public AudioClip activateSound; //Field offset: 0xB0
	public AudioClip expActivateSound; //Field offset: 0xB8
	public AudioClip confirmSound; //Field offset: 0xC0
	public AudioClip expConfirmSound; //Field offset: 0xC8
	public Effect activatedTowerAbilityEffect; //Field offset: 0xD0
	public Effect expActivatedTowerAbilityEffect; //Field offset: 0xD8
	public GameObject lineDisplay; //Field offset: 0xE0
	public GameObject expLineDisplay; //Field offset: 0xE8
	public float lineDotOffset; //Field offset: 0xF0
	public string expLineDotOffset; //Field offset: 0xF8
	public float lineDotSpacing; //Field offset: 0x100
	public string expLineDotSpacing; //Field offset: 0x108
	public int activateAnimationState; //Field offset: 0x110
	public string expActivateAnimationState; //Field offset: 0x118
	public int linkAnimationState; //Field offset: 0x120
	public string expLinkAnimationState; //Field offset: 0x128
	public int idleAnimationState; //Field offset: 0x130
	public string expIdleAnimationState; //Field offset: 0x138
	public Effect travelEffect; //Field offset: 0x140
	public Effect expTravelEffect; //Field offset: 0x148
	public float travelEffectSpeed; //Field offset: 0x150
	public string expTravelEffectSpeed; //Field offset: 0x158
	public GameObject rotatingDisplay; //Field offset: 0x160
	public GameObject expRotatingDisplay; //Field offset: 0x168

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 674
	}

	public virtual GameObject Display
	{
		 get { } //Length: 8
	}

	public TechBotLink() { }

	public virtual AbilityBehaviorModel get_Def() { }

	public virtual GameObject get_Display() { }

}

