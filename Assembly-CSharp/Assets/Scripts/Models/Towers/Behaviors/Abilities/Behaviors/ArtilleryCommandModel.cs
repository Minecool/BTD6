namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(ArtilleryCommand), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ArtilleryCommandModel : AbilityBehaviorModel
{
	public bool givesBuff; //Field offset: 0x30
	public int buffFrames; //Field offset: 0x34
	public EffectModel otherTowerEffectModel; //Field offset: 0x38

	public ArtilleryCommandModel(string name, bool givesBuff, int buffFrames, EffectModel otherTowerEffectModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

