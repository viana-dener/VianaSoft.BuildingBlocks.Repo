using Microsoft.Extensions.Localization;
using VianaSoft.BuildingBlocks.Core.Resources.Interfaces;

namespace VianaSoft.BuildingBlocks.Core.Resources
{
    public class LanguageMessage : ILanguageMessage
    {
        #region Properties

        private readonly IStringLocalizer<LanguageResource> _message;

        #endregion

        #region Builders
        public LanguageMessage(IStringLocalizer<LanguageResource> message)
        {
            _message = message;
        }
        #endregion

        #region Public Methods

        public string CreateMessage(string message)
            => $"{message}";

        public string CreateMessage(string message1, string message2)
            => $"{string.Format("{0} {1}", message1, message2)}";

        public string CreateMessage(string message1, string message2, string message3)
            => $"{string.Format("{0} {1} {2}", message1, message2, message3)}";

        public string TheResourceExists(bool displayCode = false)
            => displayCode ? $"{_message.GetString("ME00000001 TheResourceExists")}" : $"{_message.GetString("ME00000001 TheResourceExists").Name[..10]} - {_message.GetString("ME00000001 TheResourceExists")}";

        public string InvalidAuthentication(bool displayCode = false)
            => displayCode ? $"{_message.GetString("ME00000002 InvalidAuthentication")}" : $"{_message.GetString("ME00000002 InvalidAuthentication").Name[..10]} - {_message.GetString("ME00000002 InvalidAuthentication")}";

        public string InvalidAuthorization(bool displayCode = false)
            => displayCode ? $"{_message.GetString("ME00000003 InvalidAuthorization")}" : $"{_message.GetString("ME00000003 InvalidAuthorization").Name[..10]} - {_message.GetString("ME00000003 InvalidAuthorization")}";

        public string PasswordsDontMatch(bool displayCode = false)
            => displayCode ? $"{_message.GetString("ME00000004 PasswordsDontMatch")}" : $"{_message.GetString("ME00000004 PasswordsDontMatch").Name[..10]} - {_message.GetString("ME00000004 PasswordsDontMatch")}";

        public string InvalidEmail(bool displayCode = false)
            => displayCode ? $"{_message.GetString("ME00000006 InvalidEmail")}" : $"{_message.GetString("ME00000006 InvalidEmail").Name[..10]} - {_message.GetString("ME00000006 InvalidEmail")}";

        public string InvalidNumericalValue(bool displayCode = false)
            => displayCode ? $"{_message.GetString("ME00000007 InvalidNumericalValue")}" : $"{_message.GetString("ME00000007 InvalidNumericalValue").Name[..10]} - {_message.GetString("ME00000007 InvalidNumericalValue")}";

        public string InvalidPassword(bool displayCode = false)
            => displayCode ? $"{_message.GetString("ME00000008 InvalidPassword")}" : $"{_message.GetString("ME00000008 InvalidPassword").Name[..10]} - {_message.GetString("ME00000008 InvalidPassword")}";

        public string IsLockedOut(bool displayCode = false)
            => displayCode ? $"{_message.GetString("ME00000009 IsLockedOut")}" : $"{_message.GetString("ME00000009 IsLockedOut").Name[..10]} - {_message.GetString("ME00000009 IsLockedOut")}";

        public string IsNotAllowed(bool displayCode = false)
            => displayCode ? $"{_message.GetString("ME00000010 IsNotAllowed")}" : $"{_message.GetString("ME00000010 IsNotAllowed").Name[..10]} - {_message.GetString("ME00000010 IsNotAllowed")}";

        public string MinValueCharacters(string value, bool displayCode = false)
            => displayCode ? $"{string.Format(_message.GetString("ME00000011 MinValueCharacters"), value)}" : $"{_message.GetString("ME00000011 MinValueCharacters").Name[..10]} - {string.Format(_message.GetString("ME00000011 MinValueCharacters"), value)}";

        public string NotFound(bool displayCode = false)
            => displayCode ? $"{_message.GetString("ME00000012 NotFound")}" : $"{_message.GetString("ME00000012 NotFound").Name[..10]} - {_message.GetString("ME00000012 NotFound")}";

        public string Required(string value, bool displayCode = false)
            => displayCode ? $"{string.Format(_message.GetString("ME00000013 Required"), value)}" : $"{_message.GetString("ME00000013 Required").Name[..10]} - {string.Format(_message.GetString("ME00000013 Required"), value)}";

        public string RequiredFields(bool displayCode = false)
            => displayCode ? $"{_message.GetString("ME00000014 RequiredFields")}" : $"{_message.GetString("ME00000014 RequiredFields").Name[..10]} - {_message.GetString("ME00000014 RequiredFields")}";

        public string TwoFactor(bool displayCode = false)
            => displayCode ? $"{_message.GetString("ME00000015 TwoFactor")}" : $"{_message.GetString("ME00000015 TwoFactor").Name[..10]} - {_message.GetString("ME00000015 TwoFactor")}";

        public string UpdateFailed(bool displayCode = false)
            => displayCode ? $"{_message.GetString("ME00000016 UpdateFailed")}" : $"{_message.GetString("ME00000016 UpdateFailed").Name[..10]} - {_message.GetString("ME00000016 UpdateFailed")}";

        public string InvalidToken(bool displayCode = false)
            => displayCode ? $"{_message.GetString("ME00000017 InvalidToken")}" : $"{_message.GetString("ME00000017 InvalidToken").Name[..10]} - {_message.GetString("ME00000017 InvalidToken")}";

        public string PasswordRequiresNonAlphanumeric(bool displayCode = false)
            => displayCode ? $"{_message.GetString("ME00000018 PasswordRequiresNonAlphanumeric")}" : $"{_message.GetString("ME00000018 PasswordRequiresNonAlphanumeric").Name[..10]} - {_message.GetString("ME00000018 PasswordRequiresNonAlphanumeric")}";

        public string PasswordRequiresUpper(bool displayCode = false)
            => displayCode ? $"{_message.GetString("ME00000019 PasswordRequiresUpper")}" : $"{_message.GetString("ME00000019 PasswordRequiresUpper").Name[..10]} - {_message.GetString("ME00000019 PasswordRequiresUpper")}";

        public string PasswordRequiresLower(bool displayCode = false)
            => displayCode ? $"{_message.GetString("ME00000020 PasswordRequiresLower")}" : $"{_message.GetString("ME00000020 PasswordRequiresLower").Name[..10]} - {_message.GetString("ME00000020 PasswordRequiresLower")}";

        public string PasswordRequiresDigit(bool displayCode = false)
            => displayCode ? $"{_message.GetString("ME00000021 PasswordRequiresDigit")}" : $"{_message.GetString("ME00000021 PasswordRequiresDigit").Name[..10]} - {_message.GetString("ME00000021 PasswordRequiresDigit")}";

        public string ForgotEmailInvalid(bool displayCode = false)
            => displayCode ? $"{_message.GetString("ME00000022 ForgotEmailInvalid")}" : $"{_message.GetString("ME00000022 ForgotEmailInvalid").Name[..10]} - {_message.GetString("ME00000022 ForgotEmailInvalid")}";

        public string RequestSuccessfullyReceivedController(bool displayCode = false)
            => displayCode ? $"{_message.GetString("ME00000023 RequestSuccessfullyReceivedController")}" : $"{_message.GetString("ME00000023 RequestSuccessfullyReceivedController").Name[..10]} - {_message.GetString("ME00000023 RequestSuccessfullyReceivedController")}";

        public string RequestSuccessfullyReceivedOrchestrator(bool displayCode = false)
            => displayCode ? $"{_message.GetString("ME00000024 RequestSuccessfullyReceivedOrchestrator")}" : $"{_message.GetString("ME00000024 RequestSuccessfullyReceivedOrchestrator").Name[..10]} - {_message.GetString("ME00000024 RequestSuccessfullyReceivedOrchestrator")}";

        public string RequestSuccessfullyReceivedDomain(bool displayCode = false)
            => displayCode ? $"{_message.GetString("ME00000025 RequestSuccessfullyReceivedDomain")}" : $"{_message.GetString("ME00000025 RequestSuccessfullyReceivedDomain").Name[..10]} - {_message.GetString("ME00000025 RequestSuccessfullyReceivedDomain")}";

        public string RequestSuccessfullyReceivedRepository(bool displayCode = false)
            => displayCode ? $"{_message.GetString("ME00000026 RequestSuccessfullyReceivedRepository")}" : $"{_message.GetString("ME00000026 RequestSuccessfullyReceivedRepository").Name[..10]} - {_message.GetString("ME00000026 RequestSuccessfullyReceivedRepository")}";

        public string RequestSuccessfullyReceivedIntegrator(bool displayCode = false)
            => displayCode ? $"{_message.GetString("ME00000027 RequestSuccessfullyReceivedIntegrator")}" : $"{_message.GetString("ME00000027 RequestSuccessfullyReceivedIntegrator").Name[..10]} - {_message.GetString("ME00000027 RequestSuccessfullyReceivedIntegrator")}";

        public string NotChanged(bool displayCode = false)
            => displayCode ? $"{_message.GetString("ME00000028 NotChanged")}" : $"{_message.GetString("ME00000028 NotChanged").Name[..10]} - {_message.GetString("ME00000028 NotChanged")}";

        public string NotSent(bool displayCode = false)
            => displayCode ? $"{_message.GetString("ME00000029 NotSent")}" : $"{_message.GetString("ME00000029 NotSent").Name[..10]} - {_message.GetString("ME00000029 NotSent")}";

        public string NotExcluded(bool displayCode = false)
            => displayCode ? $"{_message.GetString("ME00000030 NotExcluded")}" : $"{_message.GetString("ME00000030 NotExcluded").Name[..10]} - {_message.GetString("ME00000030 NotExcluded")}";

        public string Processing(bool displayCode = false)
            => displayCode ? $"{_message.GetString("ME00000031 Processing")}" : $"{_message.GetString("ME00000031 Processing").Name[..10]} - {_message.GetString("ME00000031 Processing")}";

        public string MaxValueCharacters(string value, bool displayCode = false)
            => displayCode ? $"{string.Format(_message.GetString("ME00000032 MaxValueCharacters"), value)}" : $"{_message.GetString("ME00000032 MaxValueCharacters").Name[..10]} - {string.Format(_message.GetString("ME00000032 MaxValueCharacters"), value)}";

        public string MinorFinalDate(bool displayCode = false)
            => displayCode ? $"{_message.GetString("ME00000033 MinorFinalDate")}" : $"{_message.GetString("ME00000033 MinorFinalDate").Name[..10]} - {_message.GetString("ME00000033 MinorFinalDate")}";

        public string BiggerThen(string value, bool displayCode = false)
            => displayCode ? $"{string.Format(_message.GetString("ME00000034 BiggerThen"), value)}" : $"{_message.GetString("ME00000034 BiggerThen").Name[..10]} - {string.Format(_message.GetString("ME00000034 BiggerThen"), value)}";

        public string LessThan(string value, bool displayCode = false)
            => displayCode ? $"{string.Format(_message.GetString("ME00000035 LessThan"), value)}" : $"{_message.GetString("ME00000035 LessThan").Name[..10]} - {string.Format(_message.GetString("ME00000035 LessThan"), value)}";

        public string BiggerOrEqual(string value, bool displayCode = false)
            => displayCode ? $"{string.Format(_message.GetString("ME00000036 BiggerOrEqual"), value)}" : $"{_message.GetString("ME00000036 BiggerOrEqual").Name[..10]} - {string.Format(_message.GetString("ME00000036 BiggerOrEqual"), value)}";

        public string LessOrEqual(string value, bool displayCode = false)
            => displayCode ? $"{string.Format(_message.GetString("ME00000037 LessOrEqual"), value)}" : $"{_message.GetString("ME00000037 LessOrEqual").Name[..10]} - {string.Format(_message.GetString("ME00000037 LessOrEqual"), value)}";

        public string DeadlineGreaterThan(string value, bool displayCode = false)
            => displayCode ? $"{string.Format(_message.GetString("ME00000038 DeadlineGreaterThan"), value)}" : $"{_message.GetString("ME00000038 DeadlineGreaterThan").Name[..10]} - {string.Format(_message.GetString("ME00000038 DeadlineGreaterThan"), value)}";

        public string DeadlineLessThan(string value, bool displayCode = false)
            => displayCode ? $"{string.Format(_message.GetString("ME00000039 DeadlineLessThan"), value)}" : $"{_message.GetString("ME00000039 DeadlineLessThan").Name[..10]} - {string.Format(_message.GetString("ME00000039 DeadlineLessThan"), value)}";

        public string DeadlineGreaterOrEqual(string value, bool displayCode = false)
            => displayCode ? $"{string.Format(_message.GetString("ME00000040 DeadlineGreaterOrEqual"), value)}" : $"{_message.GetString("ME00000040 DeadlineGreaterOrEqual").Name[..10]} - {string.Format(_message.GetString("ME00000040 DeadlineGreaterOrEqual"), value)}";

        public string DeadlineLesserOrEqual(string value, bool displayCode = false)
            => displayCode ? $"{string.Format(_message.GetString("ME00000041 DeadlineLesserOrEqual"), value)}" : $"{_message.GetString("ME00000041 DeadlineLesserOrEqual").Name[..10]} - {string.Format(_message.GetString("ME00000041 DeadlineLesserOrEqual"), value)}";

        public string UploadedFileMustBeOfType(string value, bool displayCode = false)
            => displayCode ? $"{string.Format(_message.GetString("ME00000042 UploadedFileMustBeOfType"), value)}" : $"{_message.GetString("ME00000042 UploadedFileMustBeOfType").Name[..10]} - {string.Format(_message.GetString("ME00000042 UploadedFileMustBeOfType"), value)}";

        public string NotGuid(bool displayCode = false)
            => displayCode ? $"{_message.GetString("ME00000043 NotGuid")}" : $"{_message.GetString("ME00000043 NotGuid").Name[..10]} - {_message.GetString("ME00000043 NotGuid")}";

        public string NotFound(string value, bool displayCode = false)
            => displayCode ? $"{string.Format(_message.GetString("ME00000044 NotFound"), value)}" : $"{_message.GetString("ME00000044 NotFound").Name[..10]} - {string.Format(_message.GetString("ME00000044 NotFound"), value)}";

        public string Exists(bool displayCode = false)
            => displayCode ? $"{_message.GetString("ME00000045 Exists")}" : $"{_message.GetString("ME00000045 Exists").Name[..10]} - {_message.GetString("ME00000045 Exists")}";

        public string Exists(string value, bool displayCode = false)
            => displayCode ? $"{_message.GetString("ME00000046 Exists")}" : $"{_message.GetString("ME00000046 Exists").Name[..10]} - {_message.GetString("ME00000046 Exists")}";

        public string NotValid(string value, bool displayCode = false)
            => displayCode ? $"{string.Format(_message.GetString("ME00000047 NotValid"), value)}" : $"{_message.GetString("ME00000047 NotValid").Name[..10]} - {string.Format(_message.GetString("ME00000047 NotValid"), value)}";

        public string NotNull(string value, bool displayCode = false)
            => displayCode ? $"{string.Format(_message.GetString("ME00000048 NotNull"), value)}" : $"{_message.GetString("ME00000048 NotNull").Name[..10]} - {string.Format(_message.GetString("ME00000048 NotNull"), value)}";

        public string NotNull(bool displayCode = false)
            => displayCode ? $"{_message.GetString("ME00000049 NotNull")}" : $"{_message.GetString("ME00000049 NotNull").Name[..10]} - {_message.GetString("ME00000049 NotNull")}";

        #endregion
    }
}
