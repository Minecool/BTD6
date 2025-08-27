namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class AddCorvusMana : ProjectileBehavior
{
	public AddCorvusMana parent; //Field offset: 0x88
	public int amountOnEmit; //Field offset: 0x90
	public string expAmountOnEmit; //Field offset: 0x98

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 107
	}

	public AddCorvusMana() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

