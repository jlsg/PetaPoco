namespace PetaPoco
{
	// Pass as parameter value to force to DBType.AnsiString
	public class AnsiString
	{
		public AnsiString(string str)
		{
			Value = str;
		}
		public string Value { get; private set; }
	}

}