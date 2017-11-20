namespace Delegates
{
	public class DisplayPlayerNamesWithoutDelegates
	{
		void OnGameOver(PlayerStats[] allPlayerStates)
		{
			string playersNameMostKills = GetPlayersMostKills(allPlayerStates);
			string playersNameMostFlagsCaptured = GetPlayersMostFlagsCaptured(allPlayerStates);
		}

		private string GetPlayersMostFlagsCaptured(PlayerStats[] allPlayerStates)
		{
			string name = "";
			int bestScore = 0;
			foreach(var p in allPlayerStates)
			{
				int score = p.flagsCaptured;
				if(score > bestScore)
				{
					name = p.name;
					bestScore = score;
				}
			}

			return name;
		}

		private string GetPlayersMostKills(PlayerStats[] allPlayerStates)
		{
			string name = "";
			int bestScore = 0;
			foreach (var p in allPlayerStates)
			{
				int score = p.kills;
				if (score > bestScore)
				{
					name = p.name;
					bestScore = score;
				}
			}

			return name;
		}
	}
}
