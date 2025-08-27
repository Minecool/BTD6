namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(EjectAnimation), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class EjectAnimationModel : WeaponBehaviorModel
{
	public int animationState; //Field offset: 0x30

	public EjectAnimationModel(string name, int animationState) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

