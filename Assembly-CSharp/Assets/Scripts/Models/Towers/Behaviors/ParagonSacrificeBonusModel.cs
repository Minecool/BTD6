namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(ParagonSacrificeBonus), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ParagonSacrificeBonusModel : TowerBehaviorModel
{
	public float bonus; //Field offset: 0x30

	public ParagonSacrificeBonusModel(string name, float bonus) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

