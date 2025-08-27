namespace Assets.Scripts.Models.CorvusSpells.OnEnd;

[Implementation(typeof(CorvusOnSpellEndEffects), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CorvusOnSpellEndEffectsModel : CorvusOnSpellEndModel
{
	public int stateOnCorvus; //Field offset: 0x38
	public int stateOnSpirit; //Field offset: 0x3C
	public EffectModel effectOnCorvusModel; //Field offset: 0x40
	public EffectModel effectOnSpiritModel; //Field offset: 0x48
	public SoundModel soundModel; //Field offset: 0x50

	public CorvusOnSpellEndEffectsModel(string name, CorvusSpellType spellType, int stateOnCorvus, int stateOnSpirit, EffectModel effectOnCorvusModel, EffectModel effectOnSpiritModel, SoundModel soundModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

