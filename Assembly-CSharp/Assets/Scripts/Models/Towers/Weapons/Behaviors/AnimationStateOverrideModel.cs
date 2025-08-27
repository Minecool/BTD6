namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(AnimationStateOverride), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AnimationStateOverrideModel : WeaponBehaviorModel
{
	public int stateFrom; //Field offset: 0x30
	public int stateTo; //Field offset: 0x34
	public int overrideWith; //Field offset: 0x38

	public AnimationStateOverrideModel(string name, int stateFrom, int stateTo, int overrideWith) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

