namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(AlternateAnimation), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AlternateAnimationModel : WeaponBehaviorModel
{
	public int states; //Field offset: 0x30
	public int originState; //Field offset: 0x34

	public AlternateAnimationModel(string name, int states, int originState) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

