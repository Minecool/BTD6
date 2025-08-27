namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class CreateEffectOnContact : ProjectileBehavior
{
	public CreateEffectOnContact parent; //Field offset: 0x88
	public Effect effect; //Field offset: 0x90
	public Effect expEffect; //Field offset: 0x98

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 189
	}

	public CreateEffectOnContact() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

