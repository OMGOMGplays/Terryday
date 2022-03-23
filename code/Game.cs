using Sandbox;

namespace TD
{
	public enum GameState 
	{
		MainMenu = 0,
		Gameplay,
		GameEnd
	}

	public partial class TDGame : Game
	{
		public GameState CurrGameState = GameState.MainMenu;

		public override void ClientJoined( Client client )
		{
			base.ClientJoined( client );

			var pawn = new TDPlayer();
			client.Pawn = pawn;

			pawn.Respawn();
		}
	}
}
