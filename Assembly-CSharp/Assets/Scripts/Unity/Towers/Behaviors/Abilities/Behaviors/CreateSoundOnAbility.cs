namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class CreateSoundOnAbility : AbilityBehavior
{
	public CreateSoundOnAbility parent; //Field offset: 0x88
	public AudioClip sound; //Field offset: 0x90
	public AudioClip expSound; //Field offset: 0x98
	public AudioClip heroSound; //Field offset: 0xA0
	public AudioClip expHeroSound; //Field offset: 0xA8
	public AudioClip heroSound2; //Field offset: 0xB0
	public AudioClip expHeroSound2; //Field offset: 0xB8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 634
	}

	public CreateSoundOnAbility() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

