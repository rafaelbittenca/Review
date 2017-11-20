namespace Delegates
{
	public class DisplayPlayerNamesWithDelegates
    {
		delegate int ScoreDelegate(PlayerStats stats);

		public void OnGameOver(PlayerStats[] allPlayerStates)
		{
			//string playersNameMostKills = 
			//	GetPlayersMostTopScore(allPlayerStates, ScoreByKillsCount);

			//string playersNameMostFlagsCaptured = 
			//	GetPlayersMostTopScore(allPlayerStates, ScoreByFlagsCount);

			// Changed to Lambda and Included 01 more
			string playerNameMostKills =
				GetPlayersMostTopScore(allPlayerStates, stats => stats.kills);

			string playerNameMostFlagsCaptured =
				GetPlayersMostTopScore(allPlayerStates, stats => stats.flagsCaptured);

			string playerNameMostDeaths =
				GetPlayersMostTopScore(allPlayerStates, stats => stats.deaths);

			System.Console.WriteLine("Most Kills: {0}", playerNameMostKills);
			System.Console.WriteLine("Most FlagsCaptured: {0}", playerNameMostFlagsCaptured);
			System.Console.WriteLine("MostDeaths: {0}", playerNameMostDeaths);
		}

		//int ScoreByKillsCount(PlayerStats stats)
		//{
		//	return stats.kills;
		//}

		//int ScoreByFlagsCount(PlayerStats stats)
		//{
		//	return stats.flagsCaptured;
		//}

		private string GetPlayersMostTopScore(PlayerStats[] allPlayerStates, ScoreDelegate scoreCalculator)
		{
			string name = "";
			int bestScore = 0;
			foreach (PlayerStats p in allPlayerStates)
			{
				int score = scoreCalculator(p);
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
