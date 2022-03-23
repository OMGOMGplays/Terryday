using Sandbox;

namespace TD
{
	partial class TDPlayer 
	{
		public int CurrentLevel = 0;
		public int ExpForNextLevel = 100;
		public int CurrExp = 0;

		public void LevelUp() 
		{
			if (CurrExp == ExpForNextLevel)
				CurrentLevel++;
			
			else return;

			// Gör mera saker.
		}
	}
}
