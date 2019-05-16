using System;

public abstract class HSMitglied : Person
{

    protected int usrId;
    protected static int usrIdCount = 0;

    public int UsrId
    {
        get { return usrId; }

        // soll ja nicht moeglich sein
        // ohne setter ist meine usrId variable allerdings schreibgeschuetzt
        set { usrId = value; }

    }

    protected HSMitglied(string firstName, string lastName, DateTime birthDay)
        : base(firstName, lastName, birthDay)
    {
        FirstName = firstName;
        LastName = lastName;
        BirthDay = birthDay;


        UsrId = usrIdCount;
        usrIdCount++;
    }


}
