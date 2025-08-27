namespace Assets.Scripts.Data.Languages;

[CreateAssetMenu(fileName = "DynamicFontReferences", menuName = "BTD6/Dynamic Font References")]
public class DynamicFontReferences : ScriptableObject
{
	internal class FontReferenceDict : SerializableDictionary<String, TMP_FontAssetReference>
	{

		public FontReferenceDict() { }

	}

	[SerializableDictionary]
	public FontReferenceDict references; //Field offset: 0x18

	public DynamicFontReferences() { }

}

