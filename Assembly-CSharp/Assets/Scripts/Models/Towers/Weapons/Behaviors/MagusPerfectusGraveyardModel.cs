namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(MagusPerfectusGraveyard), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MagusPerfectusGraveyardModel : WeaponBehaviorModel
{
	public int graveyardManaChange; //Field offset: 0x30
	public int roundUntilManaDecay; //Field offset: 0x34

	public MagusPerfectusGraveyardModel(string name, int graveyardManaChange, int roundsUntilManaDecay) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

