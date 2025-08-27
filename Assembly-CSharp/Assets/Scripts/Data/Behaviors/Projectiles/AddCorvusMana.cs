namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "AddCorvusMana", menuName = "BTD6/Behaviors/Projectiles/AddCorvusMana")]
public class AddCorvusMana : ProjectileBehavior
{
	public int amountOnEmit; //Field offset: 0x30

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 104
	}

	public AddCorvusMana() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

