using System;

class Program
{
    static void Main(string[] args)
    {
        Job bmpJob1 = new Job();
        bmpJob1._bmpJobTitle = "Software Engineer";
        bmpJob1._bmpCompany = "BYU-I Technologies";
        bmpJob1._bmpEndYear = 2024;
        bmpJob1._bmpStartYear = 2010;
        // bmpJob1.BmpDisplayJobDetails();

        Job bmpJob2 = new Job();
        bmpJob2._bmpCompany = "Super Tech Inc";
        bmpJob2._bmpJobTitle = "Quality Assurance";
        bmpJob2._bmpStartYear = 2005;
        bmpJob2._bmpEndYear = 2010;
        // bmpJob2.BmpDisplayJobDetails();

        Resume bmpMyResume = new Resume();
        bmpMyResume._bmpName = "Braldey Petson";
        bmpMyResume._bmpJobs.Add(bmpJob1);
        bmpMyResume._bmpJobs.Add(bmpJob2);

        bmpMyResume.BmpDisplay();
    }
} 