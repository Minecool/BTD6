namespace Assets.Scripts.Unity.UI_New.Main.WorldItems;

public abstract class InteractableObject : MonoBehaviour
{

	protected InteractableObject() { }

	public override bool IsInteractable() { }

	public abstract void OnInteract() { }

}

