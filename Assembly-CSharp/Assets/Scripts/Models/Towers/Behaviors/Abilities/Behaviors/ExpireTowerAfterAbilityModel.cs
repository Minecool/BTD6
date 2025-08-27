namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(ExpireTowerAfterAbility), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ExpireTowerAfterAbilityModel : AbilityBehaviorModel
{
	public int timeFrames; //Field offset: 0x30
	public int rounds; //Field offset: 0x34
	public bool useRoundTime; //Field offset: 0x38
	public EffectModel effectModel; //Field offset: 0x40
	public SoundModel sound; //Field offset: 0x48

	public ExpireTowerAfterAbilityModel(string name, int timeFrames, int rounds, bool useRoundTime, EffectModel effectModel, SoundModel sound) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

