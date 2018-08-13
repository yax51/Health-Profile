//Heart rate class

class HeartRate
{
    private int currentYear;

    public HeartRate() : this("Patrick ", "Davis", 1982, 2018) { }

    public HeartRate(string firstName, string lastName, int birthYear, int currentYear)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.BirthYear = birthYear;
        this.currentYear = currentYear;
        
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int BirthYear { get; set; }
    public int CurrentYear { get; set; }
    public int Old { get; set; }

    
    public int GetAge()
    {
        return (currentYear - BirthYear);
    }

    private int calcRate()
    {
        return (220 - GetAge());
                
    }
    public int MinRate()
    {
        return (calcRate() / 2);
    }

    public double MaxRate()
    {
        return (calcRate() * 0.85);
    }

    public string FName()
    {
        return FirstName;

    }
    
    public string LName()
    {
        return LastName;
    }

    public int old()
    {
        return (currentYear - BirthYear);
    }
    
}


  