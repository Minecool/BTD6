namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(Darkshift), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DarkshiftModel : AbilityBehaviorModel
{
	public bool restrictToTowerRadius; //Field offset: 0x30
	public float placementZoneAssetRadius; //Field offset: 0x34
	public PrefabReference placementZoneAsset; //Field offset: 0x38
	public SoundModel darkshiftSound; //Field offset: 0x40
	public EffectModel disappearEffectModel; //Field offset: 0x48
	public EffectModel reappearEffectModel; //Field offset: 0x50

	public DarkshiftModel(string name, bool restrictToTowerRadius, float placementZoneAssetRadius, PrefabReference placementZoneAsset, SoundModel darkshiftSound, EffectModel disappearEffectModel, EffectModel reappearEffectModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

