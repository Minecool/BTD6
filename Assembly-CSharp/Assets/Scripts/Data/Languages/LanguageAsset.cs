namespace Assets.Scripts.Data.Languages;

public class LanguageAsset : ScriptableObject
{
	internal class LanguageDict : SerializableDictionary<Language, SpriteReference>
	{

		public LanguageDict() { }

	}

	[SerializableDictionary]
	public LanguageDict languages; //Field offset: 0x18

	public LanguageAsset() { }

}

