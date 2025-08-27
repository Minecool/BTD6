namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(CycleAnimation), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CycleAnimationModel : WeaponBehaviorModel
{
	public int minAnimationState; //Field offset: 0x30
	public int maxAnimationState; //Field offset: 0x34
	public string loopMode; //Field offset: 0x38
	public bool randomize; //Field offset: 0x40

	public CycleAnimationModel(string name, int minAnimationState, int maxAnimationState, string loopMode, bool randomize) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

