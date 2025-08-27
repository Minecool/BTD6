namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(CollectCreatedProjectile), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CollectCreatedProjectileModel : TowerBehaviorModel
{
	public string projectileId; //Field offset: 0x30

	public CollectCreatedProjectileModel(string name, string projectileId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

