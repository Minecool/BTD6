namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class ArcaneMetamorphosis : AbilityBehavior
{
	public int manaPerSecond; //Field offset: 0x88
	public GameObject displayDegree1; //Field offset: 0x90
	public GameObject expDisplayDegree1; //Field offset: 0x98
	public GameObject displayDegree2; //Field offset: 0xA0
	public GameObject expDisplayDegree2; //Field offset: 0xA8
	public GameObject displayDegree3; //Field offset: 0xB0
	public GameObject expDisplayDegree3; //Field offset: 0xB8
	public GameObject displayDegree4; //Field offset: 0xC0
	public GameObject expDisplayDegree4; //Field offset: 0xC8
	public GameObject displayDegree5; //Field offset: 0xD0
	public GameObject expDisplayDegree5; //Field offset: 0xD8
	public Effect effectTower; //Field offset: 0xE0
	public Effect expEffectTower; //Field offset: 0xE8
	public Effect effectSubTower; //Field offset: 0xF0
	public Effect expEffectSubTower; //Field offset: 0xF8
	public Effect effectEndTower; //Field offset: 0x100
	public Effect expEffectEndTower; //Field offset: 0x108
	public Effect effectEndSubTower; //Field offset: 0x110
	public Effect expEffectEndSubTower; //Field offset: 0x118
	public int endAnimationState; //Field offset: 0x120
	public string expEndAnimationState; //Field offset: 0x128

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 1682
	}

	public ArcaneMetamorphosis() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

