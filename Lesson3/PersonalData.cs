namespace Lesson3;

public class PersonalData
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string MiddleName { get; set; }
    public required bool IsSubscribeOnNotification { get; set; }

    public override string ToString()
    {
        return $"{nameof(FirstName)}: {FirstName}, {nameof(LastName)}: {LastName}, {nameof(LastName)}: {MiddleName}, {nameof(IsSubscribeOnNotification)}: {IsSubscribeOnNotification}";
    }
}