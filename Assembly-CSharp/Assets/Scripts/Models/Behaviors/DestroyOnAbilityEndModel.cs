namespace Assets.Scripts.Models.Behaviors;

[Implementation(typeof(DestroyOnAbilityEnd), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DestroyOnAbilityEndModel : Model
{
	public Ability ability; //Field offset: 0x30

	public DestroyOnAbilityEndModel(string name, Ability ability) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

