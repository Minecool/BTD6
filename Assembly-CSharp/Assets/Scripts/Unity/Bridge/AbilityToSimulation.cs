namespace Assets.Scripts.Unity.Bridge;

public class AbilityToSimulation
{
	public readonly AbilityModel model; //Field offset: 0x10
	private readonly Ability ability; //Field offset: 0x18
	public readonly ObjectId tower; //Field offset: 0x20
	private UnityToSimulation sim; //Field offset: 0x28

	public float CooldownRemaining
	{
		 get { } //Length: 38
	}

	public float CooldownTotal
	{
		 get { } //Length: 31
	}

	public int CurrentAdditionalCharges
	{
		 get { } //Length: 29
	}

	public int FrameAdded
	{
		 get { } //Length: 26
	}

	public bool IsActive
	{
		 get { } //Length: 29
	}

	public bool IsDestroyed
	{
		 get { } //Length: 19
	}

	public bool IsEnabled
	{
		 get { } //Length: 29
	}

	public bool IsReady
	{
		 get { } //Length: 32
	}

	public bool ShowAbilityInBottomRow
	{
		 get { } //Length: 29
	}

	public bool ShowInAbilityMenu
	{
		 get { } //Length: 29
	}

	public TowerToSimulation Tower
	{
		 get { } //Length: 39
	}

	public AbilityToSimulation(UnityToSimulation sim, Ability ability, ObjectId tower) { }

	public void Activate() { }

	public void ApplyCustomInputData(CustomInputData data) { }

	public bool CanUseAbility() { }

	public float get_CooldownRemaining() { }

	public float get_CooldownTotal() { }

	public int get_CurrentAdditionalCharges() { }

	public int get_FrameAdded() { }

	public bool get_IsActive() { }

	public bool get_IsDestroyed() { }

	public bool get_IsEnabled() { }

	public bool get_IsReady() { }

	public bool get_ShowAbilityInBottomRow() { }

	public bool get_ShowInAbilityMenu() { }

	public TowerToSimulation get_Tower() { }

	public SpriteReference GetAbilityIcon() { }

	public string GetCustomInputClass(bool onAbilityActived = true) { }

	public object GetCustomInputData() { }

	public void ResetCooldown() { }

}

