namespace VianaSoft.BuildingBlocks.Core.Resources.Interfaces
{
    public interface ILanguageMessage
    {
        string CreateMessage(string message);
        string CreateMessage(string message1, string message2);
        string CreateMessage(string message1, string message2, string message3);
        string TheResourceExists(bool displayCode = false);
        string InvalidAuthentication(bool displayCode = false);
        string InvalidAuthorization(bool displayCode = false);
        string PasswordsDontMatch(bool displayCode = false);
        string InvalidEmail(bool displayCode = false);
        string InvalidNumericalValue(bool displayCode = false);
        string InvalidPassword(bool displayCode = false);
        string IsLockedOut(bool displayCode = false);
        string IsNotAllowed(bool displayCode = false);
        string MinValueCharacters(string value, bool displayCode = false);
        string NotFound(bool displayCode = false);
        string Required(string value, bool displayCode = false);
        string RequiredFields(bool displayCode = false);
        string TwoFactor(bool displayCode = false);
        string UpdateFailed(bool displayCode = false);
        string InvalidToken(bool displayCode = false);
        string PasswordRequiresNonAlphanumeric(bool displayCode = false);
        string PasswordRequiresUpper(bool displayCode = false);
        string PasswordRequiresLower(bool displayCode = false);
        string PasswordRequiresDigit(bool displayCode = false);
        string ForgotEmailInvalid(bool displayCode = false);
        string RequestSuccessfullyReceivedController(bool displayCode = false);
        string RequestSuccessfullyReceivedOrchestrator(bool displayCode = false);
        string RequestSuccessfullyReceivedDomain(bool displayCode = false);
        string RequestSuccessfullyReceivedRepository(bool displayCode = false);
        string RequestSuccessfullyReceivedIntegrator(bool displayCode = false);
        string NotChanged(bool displayCode = false);
        string NotSent(bool displayCode = false);
        string NotExcluded(bool displayCode = false);
        string Processing(bool displayCode = false);
        string MaxValueCharacters(string value, bool displayCode = false);
        string MinorFinalDate(bool displayCode = false);
        string BiggerThen(string value, bool displayCode = false);
        string LessThan(string value, bool displayCode = false);
        string BiggerOrEqual(string value, bool displayCode = false);
        string LessOrEqual(string value, bool displayCode = false);
        string DeadlineGreaterThan(string value, bool displayCode = false);
        string DeadlineLessThan(string value, bool displayCode = false);
        string DeadlineGreaterOrEqual(string value, bool displayCode = false);
        string DeadlineLesserOrEqual(string value, bool displayCode = false);
        string UploadedFileMustBeOfType(string value, bool displayCode = false);
        string NotGuid(bool displayCode = false);
        string NotFound(string value, bool displayCode = false);
        string Exists(bool displayCode = false);
        string Exists(string value, bool displayCode = false);
        string NotValid(string value, bool displayCode = false);
        string NotNull(string value, bool displayCode = false);
        string NotNull(bool displayCode = false);
    }
}
