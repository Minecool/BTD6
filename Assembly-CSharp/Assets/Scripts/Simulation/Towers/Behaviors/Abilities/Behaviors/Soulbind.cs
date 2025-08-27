namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class Soulbind : AbilityBehavior
{
	private static String[] towerBanList; //Field offset: 0x0
	public SoulbindModel soulbindModel; //Field offset: 0x68
	private Tower selectedTower; //Field offset: 0x70
	private List<Entity> effects; //Field offset: 0x78
	private bool hideUI; //Field offset: 0x80

	private static Soulbind() { }

	public Soulbind() { }

	public virtual void Activate() { }

	private void AddListeners() { }

	public virtual void Attatched() { }

	public virtual bool CanUseAbility() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private bool IsBanned(Tower tower) { }

	private void OnCancel(int inputId) { }

	protected virtual void OnDestroy() { }

	private void OnPointerDown(Vector2 position) { }

	public void OnPointerUpFinished(Vector2 position) { }

	public void OnRoundOver(int round) { }

	private void RemoveEffects() { }

	private void RemoveListeners() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

