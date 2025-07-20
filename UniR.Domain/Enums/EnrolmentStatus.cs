namespace UniR.Domain.Enums;

public enum EnrolmentStatus
{
    Active = 1,
      Withdrawn = Active << 1,
    Suspended = Active << 2,
    Completed = Active << 3,
}