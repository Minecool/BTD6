namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(TheBlazingSun), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TheBlazingSunModel : WeaponBehaviorModel
{
	public int maxStacks; //Field offset: 0x30
	public int stacksToBurn; //Field offset: 0x34
	public AddBehaviorToBloonModel burnBehaviorModel; //Field offset: 0x38
	public float attackSpeedPerStack; //Field offset: 0x40
	public int debuffExpiresAfterFrames; //Field offset: 0x44
	public ProjectileModel burnBehaviorArea; //Field offset: 0x48
	public EmissionModel emission; //Field offset: 0x50
	public EffectModel ejectEffectModel; //Field offset: 0x58
	public EffectModel ejectEffectOverheatModel; //Field offset: 0x60

	public TheBlazingSunModel(string name, int maxStacks, int stacksToBurn, AddBehaviorToBloonModel burnBehaviorModel, float attackSpeedPerStack, int debuffExpiresAfterFrames, ProjectileModel burnBehaviorArea, EffectModel ejectEffectModel, EffectModel ejectEffectOverheatModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

