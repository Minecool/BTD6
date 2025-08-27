namespace Assets.Scripts.Data.Quests.InGame;

public class DialogueInGameOnBloonSpawned : DialogueDataTaskInGame
{
	[BloonType]
	public string bloonType; //Field offset: 0x28

	public DialogueInGameOnBloonSpawned() { }

	public virtual void Bind(bool isLoadedSave) { }

	public void OnBloonSpawn(string bloonBaseId) { }

	public virtual void Unbind() { }

}

