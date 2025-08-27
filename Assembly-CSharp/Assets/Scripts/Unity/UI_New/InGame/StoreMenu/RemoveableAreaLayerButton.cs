namespace Assets.Scripts.Unity.UI_New.InGame.StoreMenu;

public class RemoveableAreaLayerButton : AreaLayerButton
{
	public Toggle onTriggerVisbileTgl; //Field offset: 0x88
	public Toggle onShowVisibleTgl; //Field offset: 0x90
	public Toggle onHideVisibleTgl; //Field offset: 0x98

	public RemoveableAreaLayerButton() { }

	public virtual string GetId() { }

	public virtual string GetLocalisedTitle() { }

	public virtual void Initialise(int categoryLayerIndex, int worldSortingIndex, object metaData) { }

	public void OnHideVisibleToggled(bool isVisible) { }

	public void OnShowVisibleToggled(bool isVisible) { }

	public void OnTriggerVisbilityToggled(bool isVisible) { }

}

