namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(AnimDamageState), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AnimDamageStateModel : BloonBehaviorModel
{
	public int numOfAnimStates; //Field offset: 0x30

	public AnimDamageStateModel() { }

	public AnimDamageStateModel(string name, int numOfAnimStates) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

