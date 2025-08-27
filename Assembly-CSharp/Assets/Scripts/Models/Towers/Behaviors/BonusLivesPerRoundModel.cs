namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(BonusLivesPerRound), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BonusLivesPerRoundModel : TowerBehaviorModel
{
	public int amount; //Field offset: 0x30
	public float lifespan; //Field offset: 0x34
	public PrefabReference assetId; //Field offset: 0x38

	public BonusLivesPerRoundModel(string name, int amount, float lifespan, PrefabReference assetId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

