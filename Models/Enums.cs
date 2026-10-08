namespace DocTient.Models;

public enum UserRole
{
    Patient,
    Doctor,
    Admin
}

public enum VitalType
{
    BloodPressure,
    HeartRate,
    Temperature,
    BloodOxygen,
    Weight,
    BloodGlucose
}

public enum VitalStatus
{
    Normal,
    Monitor,
    Critical
}

public enum AppointmentStatus
{
    Scheduled,
    Confirmed,
    Completed,
    Cancelled,
    NoShow
}

public enum HealthRecordType
{
    ConsultationNote,
    LabResult,
    Prescription,
    DiagnosticReport,
    Vaccination
}

public enum MedicationFrequency
{
    OnceDaily,
    TwiceDaily,
    ThreeTimesDaily,
    Weekly,
    AsNeeded
}
