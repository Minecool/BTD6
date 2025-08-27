namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(PauseOtherAttacks), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PauseOtherAttacksModel : WeaponBehaviorModel
{
	public float duration; //Field offset: 0x30
	public int durationFrames; //Field offset: 0x34

	public PauseOtherAttacksModel(string name, float duration) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

