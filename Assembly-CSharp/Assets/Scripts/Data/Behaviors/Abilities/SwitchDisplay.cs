namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "SwitchDisplay", menuName = "BTD6/Behaviors/Abilities/SwitchDisplay")]
public class SwitchDisplay : AbilityBehavior
{
	public float lifespan; //Field offset: 0x30
	public bool excludeSubTowers; //Field offset: 0x34
	public bool resetOnDefeatScreen; //Field offset: 0x35
	public PrefabReference display; //Field offset: 0x38
	public Effect createEffectOnSwitchBack; //Field offset: 0x40
	public int animationStateOnActivate; //Field offset: 0x48

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 303
	}

	public SwitchDisplay() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

