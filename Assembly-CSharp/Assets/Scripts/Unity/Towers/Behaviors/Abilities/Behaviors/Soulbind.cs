namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class Soulbind : AbilityBehavior
{
	public Soulbind parent; //Field offset: 0x88
	public GameObject selectionObject; //Field offset: 0x90
	public GameObject expSelectionObject; //Field offset: 0x98
	public Effect soulbindEffectOnTarget; //Field offset: 0xA0
	public Effect expSoulbindEffectOnTarget; //Field offset: 0xA8
	public GameObject soulbindEffectOnBoundTargets; //Field offset: 0xB0
	public GameObject expSoulbindEffectOnBoundTargets; //Field offset: 0xB8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 319
	}

	public Soulbind() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

