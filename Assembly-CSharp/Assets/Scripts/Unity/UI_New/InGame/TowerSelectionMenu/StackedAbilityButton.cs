namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu;

public class StackedAbilityButton : AbilityButton
{
	public NK_TextMeshProUGUI abilityCount; //Field offset: 0x90
	public GameObject abilityCountContainer; //Field offset: 0x98
	private List<AbilityToSimulation> abilities; //Field offset: 0xA0
	private AbilityToSimulation currentAbility; //Field offset: 0xA8

	public StackedAbilityButton() { }

	public void AddAbility(AbilityToSimulation value, int ownerId) { }

	public virtual void CheckCooldown() { }

	public virtual AbilityToSimulation GetAbility() { }

	public int GetReadyCount() { }

	public virtual void OnClick() { }

	public virtual void SetAbility(AbilityToSimulation value, int ownerId) { }

	public void Update() { }

	protected virtual void UpdateButton() { }

}

