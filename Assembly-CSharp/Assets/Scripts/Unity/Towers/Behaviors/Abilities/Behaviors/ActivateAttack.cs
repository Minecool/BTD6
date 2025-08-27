namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class ActivateAttack : AbilityBehavior
{
	public ActivateAttack parent; //Field offset: 0x88
	public float lifespan; //Field offset: 0x90
	public string expLifespan; //Field offset: 0x98
	public bool processOnActivate; //Field offset: 0xA0
	public string expProcessOnActivate; //Field offset: 0xA8
	public bool cancelIfNoTargets; //Field offset: 0xB0
	public string expCancelIfNoTargets; //Field offset: 0xB8
	public bool pauseExisting; //Field offset: 0xC0
	public string expPauseExisting; //Field offset: 0xC8
	public bool endOnRoundEnd; //Field offset: 0xD0
	public string expEndOnRoundEnd; //Field offset: 0xD8
	public bool endOnDefeatScreen; //Field offset: 0xE0
	public string expEndOnDefeatScreen; //Field offset: 0xE8
	public bool isOneShot; //Field offset: 0xF0
	public string expIsOneShot; //Field offset: 0xF8
	public bool isSaved; //Field offset: 0x100
	public string expIsSaved; //Field offset: 0x108

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 415
	}

	public ActivateAttack() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

