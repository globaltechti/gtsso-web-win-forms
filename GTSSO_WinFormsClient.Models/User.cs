using GTSSO_WinFormsClient.Models;

namespace GTSSO_WinFormsClient
{
    public class User(bool authenticated, bool requiredMfa, bool requireEnrollment)
    {
        public bool Authenticated { get; set; } = authenticated;
        public bool RequireMfa { get; private set; } = requiredMfa;
        public bool RequireEnrollement { get; private set; } = requireEnrollment;

        public TokenJWT Token { get; set; }
    }
}
