namespace SD.pesel;

public class PersonId
{
    private readonly string _id;

    public PersonId(string Id)
    {
        _id = Id;
    }



    /// <summary>
    /// Get full year from PESEL
    /// </summary>
    /// <returns></returns>
    public int GetYear()
    {
        return 0;
    }

    /// <summary>
    /// Get month from PESEL
    /// </summary>
    public int GetMonth()
    {
        string month = _id.Substring(startIndex: 2, length: 2);
        int monthInInt = int.Parse(month);
        return monthInInt;
    }


    /// <summary>
    /// Get day from PESEL
    /// </summary>
    /// <returns></returns>
    public int GetDay()
    {
        string day = _id.Substring(startIndex: 4, length: 2);
        int dayInInt = int.Parse(day);
        return dayInInt;
    }

    /// <summary>
    /// Get year of birth from PESEL
    /// </summary>
    /// <returns></returns>
    public int GetYearOfBirth()
    {
        string year = _id.Substring(startIndex: 0, length: 2);
        int yearInInt = int.Parse(year);
        return yearInInt;



    }

    /// <summary>
    /// Get gender from PESEL
    /// </summary>
    /// <returns>m</returns>
    /// <returns>f</returns>
    public string GetGender()
    {
        string gender = _id.Substring(startIndex: 9, length: 1);
        int genderInInt = int.Parse(gender);
        return gender;
    }

    ///return _id.Substring(startIndex: 9, length: 1);


    /// <summary>
    /// check if PESEL is valid
    /// </summary>
    /// <returns></returns>
    public bool IsValid()
    {
        return true;
    }
}