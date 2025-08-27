namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(ActivateVisibilitySupportZone), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ActivateVisibilitySupportZoneModel : AbilityBehaviorBuffModel
{
	public float range; //Field offset: 0x48
	public float maxNumTowersModified; //Field offset: 0x4C
	public string mutatorId; //Field offset: 0x50
	public bool isUnique; //Field offset: 0x58
	public bool canEffectThisTower; //Field offset: 0x59
	[SerializeField]
	private float lifespan; //Field offset: 0x5C
	public float lifespanFrames; //Field offset: 0x60
	public DisplayModel displayModel; //Field offset: 0x68
	public TowerFilterModel[] filters; //Field offset: 0x70
	public bool useTowerRange; //Field offset: 0x78

	public ActivateVisibilitySupportZoneModel(string name, string mutatorId, bool isUnique, float range, float maxNumTowersModified, bool canEffectThisTower, float lifespan, DisplayModel addEffectToTowersAffected, string buffLocsName, string buffIconName, TowerFilterModel[] filters, bool useTowerRange) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

