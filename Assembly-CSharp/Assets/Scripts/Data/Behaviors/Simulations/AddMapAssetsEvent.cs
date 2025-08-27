namespace Assets.Scripts.Data.Behaviors.Simulations;

[CreateAssetMenu(fileName = "NewAddMapAssetsEvent", menuName = "BTD6/Behaviors/Simulations/AddMapAssetsEvent")]
public class AddMapAssetsEvent : SimulationBehavior
{
	public bool disableAmbientMapFx; //Field offset: 0x30
	public PrefabReference[] fXPrefabs; //Field offset: 0x38

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 106
	}

	public AddMapAssetsEvent() { }

	public virtual SimulationBehaviorModel get_Def() { }

}

