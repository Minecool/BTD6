namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class SwitchDisplay : AbilityBehavior
{
	public SwitchDisplay parent; //Field offset: 0x88
	public float lifespan; //Field offset: 0x90
	public string expLifespan; //Field offset: 0x98
	public bool excludeSubTowers; //Field offset: 0xA0
	public string expExcludeSubTowers; //Field offset: 0xA8
	public bool resetOnDefeatScreen; //Field offset: 0xB0
	public string expResetOnDefeatScreen; //Field offset: 0xB8
	public GameObject display; //Field offset: 0xC0
	public GameObject expDisplay; //Field offset: 0xC8
	public Effect createEffectOnSwitchBack; //Field offset: 0xD0
	public Effect expCreateEffectOnSwitchBack; //Field offset: 0xD8
	public int animationStateOnActivate; //Field offset: 0xE0
	public string expAnimationStateOnActivate; //Field offset: 0xE8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 408
	}

	public SwitchDisplay() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

