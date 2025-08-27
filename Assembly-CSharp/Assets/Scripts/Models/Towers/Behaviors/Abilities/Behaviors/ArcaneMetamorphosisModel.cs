namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(ArcaneMetamorphosis), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ArcaneMetamorphosisModel : AbilityBehaviorModel
{
	public int manaPerSecond; //Field offset: 0x30
	public AssetPathModel[] displayDegreePaths; //Field offset: 0x38
	public EffectModel effectTowerModel; //Field offset: 0x40
	public EffectModel effectSubtowerModel; //Field offset: 0x48
	public EffectModel effectEndTowerModel; //Field offset: 0x50
	public EffectModel effectEndSubtowerModel; //Field offset: 0x58
	public int endAnimationState; //Field offset: 0x60

	public ArcaneMetamorphosisModel(string name, int manaPerSecond, AssetPathModel[] displayDegreePaths, EffectModel effectTowerModel, EffectModel effectSubtowerModel, EffectModel effectEndTowerModel, EffectModel effectEndSubtowerModel, int endAnimationState) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

