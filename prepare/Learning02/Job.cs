public class Job
{
    public string _bmpCompany;
    public string _bmpJobTitle;
    public int _bmpStartYear;
    public int _bmpEndYear;

    public void BmpDisplayJobDetails()
{
    Console.WriteLine($"{_bmpJobTitle} ({_bmpCompany}) {_bmpStartYear}-{_bmpEndYear}");
}

}