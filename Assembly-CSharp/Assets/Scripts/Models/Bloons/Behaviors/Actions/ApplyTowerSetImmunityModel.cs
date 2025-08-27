namespace Assets.Scripts.Models.Bloons.Behaviors.Actions;

[Implementation(typeof(ApplyTowerSetImmunity), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ApplyTowerSetImmunityModel : BloonBehaviorActionModel
{
	internal struct TowerTypeImmunity : IEquatable<TowerTypeImmunity>
	{
		public string id; //Field offset: 0x0
		public TowerSet towerType; //Field offset: 0x8

		public override bool Equals(TowerTypeImmunity other) { }

	}

	public string id; //Field offset: 0x38
	public TowerTypeImmunity[] immunities; //Field offset: 0x40

	public ApplyTowerSetImmunityModel(string name, string actionId, string id, TowerTypeImmunity[] immunities) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

