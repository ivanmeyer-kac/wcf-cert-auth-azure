using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Security.Cryptography.X509Certificates;

namespace SmartHotel.Registration.Wcf
{
    public class CustomCertificateValidator : X509CertificateValidator
    {
        public override void Validate(X509Certificate2 certificate)
        {
            // Implement your validation logic here
            // For example, check the certificate's thumbprint or issuer
            if (certificate.Thumbprint != "E2265471EEBC884563D682AFCCF162C7B31C61AA".ToUpper())
            {
                throw new SecurityTokenValidationException("Certificate validation failed.");
            }
        }
    }
}