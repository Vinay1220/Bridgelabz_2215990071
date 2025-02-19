using System;
using System.Collections.Generic;
using System.Linq;

class InsurancePolicy : IComparable<InsurancePolicy>
{
    public string PolicyNumber { get; }
    public string CoverageType { get; }
    public DateTime ExpiryDate { get; }

    public InsurancePolicy(string policyNumber, string coverageType, DateTime expiryDate)
    {
        PolicyNumber = policyNumber;
        CoverageType = coverageType;
        ExpiryDate = expiryDate;
    }

    public int CompareTo(InsurancePolicy other)
    {
        return ExpiryDate.CompareTo(other.ExpiryDate);
    }

    public override bool Equals(object obj)
    {
        return obj is InsurancePolicy policy && PolicyNumber == policy.PolicyNumber;
    }

    public override int GetHashCode()
    {
        return PolicyNumber.GetHashCode();
    }

    public override string ToString()
    {
        return PolicyNumber + " | " + CoverageType + " | Expiry: " + ExpiryDate.ToShortDateString();
    }
}

class InsurancePolicyManagement
{
    private HashSet<InsurancePolicy> policySet = new HashSet<InsurancePolicy>();
    private LinkedList<InsurancePolicy> policyOrderList = new LinkedList<InsurancePolicy>();
    private SortedSet<InsurancePolicy> sortedPolicies = new SortedSet<InsurancePolicy>();
    private Dictionary<string, List<InsurancePolicy>> duplicatePolicies = new Dictionary<string, List<InsurancePolicy>>();

    public void AddPolicy(InsurancePolicy policy)
    {
        if (!policySet.Add(policy))
        {
            if (!duplicatePolicies.ContainsKey(policy.PolicyNumber))
                duplicatePolicies[policy.PolicyNumber] = new List<InsurancePolicy>();
            duplicatePolicies[policy.PolicyNumber].Add(policy);
        }
        else
        {
            policyOrderList.AddLast(policy);
            sortedPolicies.Add(policy);
        }
    }

    public List<InsurancePolicy> GetAllPolicies()
    {
        return policySet.ToList();
    }

    public List<InsurancePolicy> GetExpiringSoonPolicies()
    {
        DateTime threshold = DateTime.Today.AddDays(30);
        return sortedPolicies.Where(p => p.ExpiryDate <= threshold).ToList();
    }

    public List<InsurancePolicy> GetPoliciesByCoverage(string coverageType)
    {
        return policySet.Where(p => p.CoverageType.Equals(coverageType, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public Dictionary<string, List<InsurancePolicy>> GetDuplicatePolicies()
    {
        return duplicatePolicies;
    }

    public void DisplayPolicies(List<InsurancePolicy> policies)
    {
        foreach (var policy in policies)
            Console.WriteLine(policy);
    }
}

class Program
{
    static void Main(string[] args)
    {
        InsurancePolicyManagement manager = new InsurancePolicyManagement();

        manager.AddPolicy(new InsurancePolicy("P123", "Health", new DateTime(2025, 5, 10)));
        manager.AddPolicy(new InsurancePolicy("P456", "Auto", new DateTime(2024, 3, 15)));
        manager.AddPolicy(new InsurancePolicy("P789", "Life", new DateTime(2024, 4, 5)));
        manager.AddPolicy(new InsurancePolicy("P101", "Home", new DateTime(2024, 2, 20)));
        manager.AddPolicy(new InsurancePolicy("P123", "Health", new DateTime(2025, 5, 10))); // Duplicate

        Console.WriteLine("All Unique Policies:");
        manager.DisplayPolicies(manager.GetAllPolicies());

        Console.WriteLine("\nPolicies Expiring Within 30 Days:");
        manager.DisplayPolicies(manager.GetExpiringSoonPolicies());

        Console.WriteLine("\nPolicies with Coverage Type 'Health':");
        manager.DisplayPolicies(manager.GetPoliciesByCoverage("Health"));

        Console.WriteLine("\nDuplicate Policies:");
        foreach (var entry in manager.GetDuplicatePolicies())
        {
            Console.WriteLine("Policy Number: " + entry.Key);
            manager.DisplayPolicies(entry.Value);
        }
    }
}