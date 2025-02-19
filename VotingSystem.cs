using System;
using System.Collections.Generic;

public class VotingSystem
{
    // Dictionary to store votes (candidate name -> number of votes)
    private Dictionary<string, int> votes = new Dictionary<string, int>();

    // List to store the order in which votes were cast
    private List<string> voteOrder = new List<string>();

    // Method to cast a vote
    public void CastVote(string candidate)
    {
        if (votes.ContainsKey(candidate))
        {
            votes[candidate]++;
        }
        else
        {
            votes[candidate] = 1;
        }

        // Keep track of the order of voting
        voteOrder.Add(candidate);
    }

    // Method to display the voting results sorted by the number of votes
    public void DisplayResults()
    {
        // SortedDictionary to display results in order of votes
        var sortedResults = new SortedDictionary<int, List<string>>();

        foreach (var vote in votes)
        {
            if (!sortedResults.ContainsKey(vote.Value))
            {
                sortedResults[vote.Value] = new List<string>();
            }
            sortedResults[vote.Value].Add(vote.Key);
        }

        // Display the sorted results
        foreach (var result in sortedResults)
        {
            Console.WriteLine("Votes: " + result.Key);
            foreach (var candidate in result.Value)
            {
                Console.WriteLine("  " + candidate);
            }
        }
    }

    // Method to display votes in the order they were cast
    public void DisplayVoteOrder()
    {
        Console.WriteLine("Votes in order of casting:");
        foreach (var candidate in voteOrder)
        {
            Console.WriteLine(candidate);
        }
    }
}

// Test the VotingSystem
public class Program
{
    public static void Main()
    {
        VotingSystem votingSystem = new VotingSystem();

        // Casting votes
        votingSystem.CastVote("Alice");
        votingSystem.CastVote("Bob");
        votingSystem.CastVote("Alice");
        votingSystem.CastVote("Charlie");
        votingSystem.CastVote("Bob");

        // Display the results
        Console.WriteLine("Results (Sorted by Votes):");
        votingSystem.DisplayResults();

        // Display the order of votes
        Console.WriteLine("\nOrder of Votes Cast:");
        votingSystem.DisplayVoteOrder();
    }
}