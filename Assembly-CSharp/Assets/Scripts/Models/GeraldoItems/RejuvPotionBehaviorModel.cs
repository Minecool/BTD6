namespace Assets.Scripts.Models.GeraldoItems;

[Implementation(typeof(RejuvPotionBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RejuvPotionBehaviorModel : GeraldoItemBehaviorModel
{
	public int livesGained; //Field offset: 0x30
	public PrefabReference textEffectId; //Field offset: 0x38
	public float textEffectLifespan; //Field offset: 0x40

	public RejuvPotionBehaviorModel(string name, int livesGained, PrefabReference textEffectId, float textEffectLifespan) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

