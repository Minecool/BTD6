//Type is in global namespace

public abstract class CustomEditorManager
{

	protected CustomEditorManager() { }

	protected void CleanUpTriggered(MapEditorSpriteShapeController editor, ref TaskCompletionSource<Boolean>& tcs) { }

	public abstract void DeleteSelectedEditor() { }

	public abstract void OnMapCleared() { }

	public abstract Task ToggleEditingMode(bool isEditing, MapEditorSceneController controller, CancellationToken cancellationToken) { }

}

