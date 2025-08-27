namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(SpiritTower), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SpiritTowerModel : TowerBehaviorModel
{
	public bool playLevelUpEffect; //Field offset: 0x30
	public EffectModel effectOnUpgrade; //Field offset: 0x38

	public SpiritTowerModel(string name, bool playLevelUpEffect, EffectModel effectOnUpgrade) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

