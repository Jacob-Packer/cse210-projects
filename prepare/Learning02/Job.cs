public class Job {


    public string company;

    public string jobTitle;

    public int startYear;

    public int endYear;
    public Job(string _companyName, string _title, int _startYear, int _endYear) {
        string company = _companyName;
        string jobTitle = _title;
        int startYear = _startYear;
        int endYear = _endYear;
    }


    public void Display(){
        // Software Engineer (Microsoft) 2019-2022
        // Manager (Apple) 2022-2023
        Console.WriteLine($"{jobTitle} ({company}) {startYear}-{endYear}");
    }

}