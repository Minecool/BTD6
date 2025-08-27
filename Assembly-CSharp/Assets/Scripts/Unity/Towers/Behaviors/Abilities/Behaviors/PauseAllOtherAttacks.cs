namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class PauseAllOtherAttacks : AbilityBehavior
{
	public PauseAllOtherAttacks parent; //Field offset: 0x88
	public float lifespan; //Field offset: 0x90
	public string expLifespan; //Field offset: 0x98
	public bool endOnRoundEnd; //Field offset: 0xA0
	public string expEndOnRoundEnd; //Field offset: 0xA8
	public bool endOnDefeatScreen; //Field offset: 0xB0
	public string expEndOnDefeatScreen; //Field offset: 0xB8
	public bool ignoreAbilityAttacks; //Field offset: 0xC0
	public string expIgnoreAbilityAttacks; //Field offset: 0xC8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 191
	}

	public PauseAllOtherAttacks() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

