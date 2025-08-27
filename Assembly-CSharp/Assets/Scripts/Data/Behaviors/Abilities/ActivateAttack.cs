namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "ActivateAttack", menuName = "BTD6/Behaviors/Abilities/ActivateAttack")]
public class ActivateAttack : AbilityBehavior
{
	public float lifespan; //Field offset: 0x30
	public bool processOnActivate; //Field offset: 0x34
	public bool cancelIfNoTargets; //Field offset: 0x35
	public bool pauseExisting; //Field offset: 0x36
	public bool endOnRoundEnd; //Field offset: 0x37
	public bool endOnDefeatScreen; //Field offset: 0x38
	public bool isOneShot; //Field offset: 0x39
	public Attack[] attacks; //Field offset: 0x40
	public bool isSaved; //Field offset: 0x48

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 259
	}

	public ActivateAttack() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

