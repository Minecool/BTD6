namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(AddCorvusMana), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AddCorvusManaModel : ProjectileBehaviorModel
{
	public int amountOnEmit; //Field offset: 0x38

	public AddCorvusManaModel(string name, int amountOnEmit) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

