using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        string jsonFilePath = "ipl_data.json";
        string csvFilePath = "ipl_data.csv";
        string censoredJsonFilePath = "censored_ipl_data.json";
        string censoredCsvFilePath = "censored_ipl_data.csv";

        try
        {
            // Process JSON File
            string jsonData = File.ReadAllText(jsonFilePath);
            JArray matches = JArray.Parse(jsonData);
            foreach (JObject match in matches)
            {
                CensorMatchData(match);
            }
            File.WriteAllText(censoredJsonFilePath, matches.ToString(Formatting.Indented));

            // Process CSV File
            string[] csvLines = File.ReadAllLines(csvFilePath);
            List<string> censoredCsvLines = new List<string> { csvLines[0] };
            foreach (var line in csvLines.Skip(1))
            {
                string[] columns = line.Split(',');
                columns[1] = MaskTeamName(columns[1]); // team1
                columns[2] = MaskTeamName(columns[2]); // team2
                columns[5] = MaskTeamName(columns[5]); // winner
                columns[6] = "REDACTED"; // player_of_match
                censoredCsvLines.Add(string.Join(",", columns));
            }
            File.WriteAllLines(censoredCsvFilePath, censoredCsvLines);

            Console.WriteLine("Censorship completed successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    static void CensorMatchData(JObject match)
    {
        match["team1"] = MaskTeamName(match["team1"].ToString());
        match["team2"] = MaskTeamName(match["team2"].ToString());
        match["winner"] = MaskTeamName(match["winner"].ToString());
        match["player_of_match"] = "REDACTED";

        JObject score = (JObject)match["score"];
        List<string> keys = score.Properties().Select(p => p.Name).ToList();
        foreach (var key in keys)
        {
            int value = (int)score[key];
            score.Remove(key);
            score[MaskTeamName(key)] = value;
        }
    }

    static string MaskTeamName(string teamName)
    {
        string[] words = teamName.Split(' ');
        if (words.Length > 1)
        {
            words[1] = "***";
        }
        return string.Join(" ", words);
    }
}