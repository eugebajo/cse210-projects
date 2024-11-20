using System;

public class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    public string JobTitle
    {
        get { return _jobTitle; }
        set { _jobTitle = value; }
    }

    public string Company
    {
        get { return _company; }
        set { _company = value; }
    }

    public int StartYear
    {
        get { return _startYear; }
        set { _startYear = value; }
    }

    public int EndYear
    {
        get { return _endYear; }
        set { _endYear = value; }
    }

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
