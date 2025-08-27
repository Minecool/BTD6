namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(BeastHandlerPet), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BeastHandlerPetModel : TowerBehaviorModel
{
	public int tier; //Field offset: 0x30
	public int path; //Field offset: 0x34
	public int requiredCount; //Field offset: 0x38
	public bool canMove; //Field offset: 0x3C
	public bool rotateWhenMoved; //Field offset: 0x3D
	public int basePower; //Field offset: 0x40
	public int maxPower; //Field offset: 0x44
	public bool enableContribution; //Field offset: 0x48
	public float cooldownScaleRange; //Field offset: 0x4C
	public int pierceRange; //Field offset: 0x50
	public int damageRange; //Field offset: 0x54
	public float destroyTimeScaleRangePiranha; //Field offset: 0x58
	public float thrashKnockbackLifetimeRange; //Field offset: 0x5C
	public float stunBonusDivideMicroraptor; //Field offset: 0x60
	public int damageRangeGrappleGyrfalcon; //Field offset: 0x64
	public float speedRangeGyrfalcon; //Field offset: 0x68
	public BeastHandlerPetDisplayStepModel[] displayStepModels; //Field offset: 0x70
	public SpriteReference genericIcon; //Field offset: 0x78

	public BeastHandlerPetModel(string name, int tier, int path, int requiredCount, bool canMove, bool rotateWhenMoved, int basePower, int maxPower, bool enableContribution, float cooldownScaleRange, int pierceRange, int damageRange, float destroyTimeScaleRangePiranha, float thrashKnockbackLifetimeRange, float stunBonusDivideMicroraptor, int damageRangeGrappleGyrfalcon, float speedRangeGyrfalcon, BeastHandlerPetDisplayStepModel[] displayStepModels, Nullable<SpriteReference> genericIcon) { }

	public bool CheckTiers(Int32[] tiers, bool mustBeEqual, bool inverseTiers) { }

	public virtual Model Clone() { }

	public BeastHandlerPetDisplayStepModel GetDisplayStep(float percent) { }

	public GreatWhiteDisplayStepModel GetGreatWhiteDisplayStepModel(TowerModel towerModel, float percent) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

