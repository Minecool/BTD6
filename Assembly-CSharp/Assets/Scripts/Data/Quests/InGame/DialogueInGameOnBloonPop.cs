namespace Assets.Scripts.Data.Quests.InGame;

public class DialogueInGameOnBloonPop : DialogueDataTaskInGame
{
	[BloonType]
	public string bloonType; //Field offset: 0x28

	public DialogueInGameOnBloonPop() { }

	public virtual void Bind(bool isLoadedSave) { }

	public void OnBloonDegrade(string bloonBaseId, TowerToSimulation tower) { }

	public virtual void Unbind() { }

}

