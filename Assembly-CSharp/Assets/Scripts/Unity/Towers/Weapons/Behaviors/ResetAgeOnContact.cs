namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class ResetAgeOnContact : ProjectileBehavior
{
	public ResetAgeOnContact parent; //Field offset: 0x88

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 88
	}

	public ResetAgeOnContact() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

