namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "Soulbind", menuName = "BTD6/Behaviors/Abilities/Soulbind")]
public class Soulbind : AbilityBehavior
{
	public PrefabReference selectionObject; //Field offset: 0x30
	public Effect soulbindEffectOnTarget; //Field offset: 0x38
	public PrefabReference soulbindEffectOnBoundTargets; //Field offset: 0x40

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 239
	}

	public Soulbind() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

